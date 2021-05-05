using PluginSystem;
using Scripts;
using Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using SharedLib;


namespace GraphicsEdit
{
    public partial class MainForm : Form
    {
        readonly ToolsManager toolsManager;
        readonly ShapesManager shapesManager;
        readonly BitmapContainer bitmapContainer;
        readonly Drawer drawer;
        readonly PluginImporter pluginImporter;

        private Assembly CurrentDomain_AssemblyResolve(object sender, ResolveEventArgs args)
        {
            Assembly[] asms = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < asms.Length; ++i)
            {
                if (asms[i].FullName == args.Name)
                    return asms[i];
            }
            return null;
        }

        public MainForm()
        {
            AppDomain.CurrentDomain.AssemblyResolve += CurrentDomain_AssemblyResolve;

            InitializeComponent();

            toolsManager = ToolsManager.Instance;

            drawer = toolsManager.Drawer;
            pluginImporter = toolsManager.PluginImporter;
            LoadAllExistingPlugins();

            shapesManager = ShapesManager.Instance;

            shapesManager.CurrentShapeCreator = new CircleCreator();
            SetShapeDrawing();
            currentToolStatusLabel.Text = "Текущий инструмент: круг";

            bitmapContainer = BitmapContainer.Instance;

            penWidthField.Text = drawer.Pen.Width.ToString();
            penColorBox.BackColor = drawer.Pen.Color;
            penColorDialog.Color = drawer.Pen.Color;

            drawBox.MouseMove += DrawBox_PrePaintMouseMove;

            brushColorBox.BackColor = ((SolidBrush)drawer.Brush).Color;
            brushColorDialog.Color = ((SolidBrush)drawer.Brush).Color;

            fillToolStripButton.Checked = false;
        }

        void LoadAllExistingPlugins()
        {
            SetupPlugins(pluginImporter.ImportAll());
        }

        /// <summary>
        /// Устанавливает плагины
        /// </summary>
        /// <param name="plugins">Массив плагинов</param>
        /// <returns>Количество установленных плагинов</returns>
        int SetupPlugins(List<Plugin> plugins)
        {
            int loadedCount = 0;
            foreach (var plugin in plugins)
            {
                if (toolsManager.AddPlugin(plugin))
                {
                    if (plugin.Shape != null && plugin.ShapeCreator != null)
                    {
                        var tsi = shapesTool.DropDownItems.Add(plugin.Name);

                        tsi.MouseDown += delegate
                        {
                            shapesManager.CurrentShapeCreator = (ShapeCreator)Activator.CreateInstance(plugin.ShapeCreator);
                            if (plugin.DrawingType == DrawingType.Pen)
                            {
                                SetPenDrawing();
                                shapesTool.Image = tsi.Image;
                            }
                            else if (plugin.DrawingType == DrawingType.Shape)
                            {
                                SetShapeDrawing();
                            }

                            currentToolStatusLabel.Text = "Текущий инструмент: " + tsi.Text;
                        };
                        loadedCount++;
                    }
                }
            }
            return loadedCount;
        }

        //Переключение на рисование прямоугольников
        private void RectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapesManager.CurrentShapeCreator = new RectangleCreator();

            SetShapeDrawing();

            shapesTool.Image = rectToolStripMenuItem.Image;

            currentToolStatusLabel.Text = "Текущий инструмент: прямоугольник";
        }

        //Переключение на рисование кругов
        private void CircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapesManager.CurrentShapeCreator = new CircleCreator();

            SetShapeDrawing();

            shapesTool.Image = circleToolStripMenuItem.Image;

            currentToolStatusLabel.Text = "Текущий инструмент: круг";
        }


        //Переключение на рисование многоугольников
        private void PolygonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PolygonPointsForm polygonPointsForm = new PolygonPointsForm();
            if (polygonPointsForm.ShowDialog() == DialogResult.OK)
            {
                int amountOfPoints = polygonPointsForm.PointsAmount;

                shapesManager.CurrentShapeCreator = new RegularPolygonCreator(amountOfPoints);

                SetShapeDrawing();

                shapesTool.Image = polygonToolStripMenuItem.Image;

                currentToolStatusLabel.Text = "Текущий инструмент: " + amountOfPoints.ToString() + "-угольник ";
            }
        }

        //Переключение на рисование прямой
        private void LineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapesManager.CurrentShapeCreator = new LineCreator();

            SetShapeDrawing();

            shapesTool.Image = lineToolStripMenuItem.Image;

            currentToolStatusLabel.Text = "Текущий инструмент: прямая";
        }

        //Переключение на рисование пером по точкам
        private void LinePenToolStripMenuItem__Click(object sender, EventArgs e)
        {
            shapesManager.CurrentShapeCreator = new LineCreator();

            SetPenDrawing();

            currentToolStatusLabel.Text = "Текущий инструмент: перо(ломаная)";
        }

        private void ShapePenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shapesManager.CurrentShapeCreator = new PolygonCreator();

            SetPenDrawing();

            currentToolStatusLabel.Text = "Текущий инструмент: перо(фигура)";
        }

        //Изменение событий, связанных с рисованием  
        
        void SetPenDrawing()
        {
            drawBox.MouseUp -= DrawBox_PenMouseUp;

            drawBox.MouseDown -= DrawBox_ShapeMouseDown;
            drawBox.MouseUp -= DrawBox_ShapeMouseUp;

            drawBox.MouseUp += DrawBox_PenMouseUp;
        }
        void SetShapeDrawing()
        {
            drawBox.MouseUp -= DrawBox_ShapeMouseUp;
            drawBox.MouseDown -= DrawBox_ShapeMouseDown;

            drawBox.MouseUp -= DrawBox_PenMouseUp;

            drawBox.MouseUp += DrawBox_ShapeMouseUp;
            drawBox.MouseDown += DrawBox_ShapeMouseDown;
        }

        // Отслеживание координат положения мыши в области рисования
        private void DrawBox_MouseMove(object sender, MouseEventArgs e)
        {
            locationStripStatusLabel1.Text = "x: " + e.X + "; y: " + e.Y;
        }
        private void DrawBox_MouseLeave(object sender, EventArgs e)
        {
            locationStripStatusLabel1.Text = "x: -; y: -";
        }


        // Предпросмотр фигур при движении мыши в состоянии рисования
        void DrawBox_PrePaintMouseMove(object sender, MouseEventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                if (drawer.IsDrawing)
                {
                    bitmapContainer.Bitmap = (Bitmap)bitmapContainer.BitmapBuffer.Clone();
                    drawer.Graphics = Graphics.FromImage(bitmapContainer.Bitmap);

                    shapesManager.CurrentShapeCreator.AddPoint(e.X, e.Y);

                    var shape = shapesManager.CurrentShapeCreator.Create(
                        drawer.Pen.Width,
                        drawer.Pen.Color,
                        brushColorBox.BackColor,
                        fillToolStripButton.Checked);

                    if (shape != null)
                    {
                        drawer.Paint(shape);
                        drawBox.Image = bitmapContainer.Bitmap;                          
                    }

                    shapesManager.CurrentShapeCreator.RemoveLastPoint();
                }
            }

        }

        //Событие рисования для режима рисования по точкам       
        private void DrawBox_PenMouseUp(object sender, MouseEventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (!drawer.IsDrawing)
                    {
                        drawer.IsDrawing = false;
                        shapesManager.CurrentShapeCreator.ResetPoints();
                        bitmapContainer.BitmapBuffer = (Bitmap)bitmapContainer.Bitmap.Clone();
                        drawer.IsDrawing = true;
                    }
                    shapesManager.CurrentShapeCreator.AddPoint(e.X, e.Y);
                }
                else if (e.Button == MouseButtons.Right)
                {
                    drawer.IsDrawing = false;

                    var shape = shapesManager.CurrentShapeCreator.Create(
                        drawer.Pen.Width,
                        penColorBox.BackColor,
                        brushColorBox.BackColor,
                        fillToolStripButton.Checked);

                    if (shape != null)
                    {
                        bitmapContainer.Bitmap = bitmapContainer.BitmapBuffer;
                        drawer.Graphics = Graphics.FromImage(bitmapContainer.Bitmap);

                        shapesManager.AddShape(shape);
                        drawer.Paint(shape);
                        drawBox.Image = bitmapContainer.Bitmap;
                    }
                    else
                    {
                        bitmapContainer.Bitmap = bitmapContainer.BitmapBuffer;
                        drawer.Graphics = Graphics.FromImage(bitmapContainer.Bitmap);
                        drawBox.Image = bitmapContainer.Bitmap;
                    }

                    shapesManager.CurrentShapeCreator.ResetPoints();
                }
            }
        }

        //События рисования для режима рисования фигур
        void DrawBox_ShapeMouseDown(object sender, MouseEventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                drawer.IsDrawing = false;
                shapesManager.CurrentShapeCreator.ResetPoints();

                bitmapContainer.BitmapBuffer = (Bitmap)bitmapContainer.Bitmap.Clone();

                shapesManager.CurrentShapeCreator.AddPoint(e.X, e.Y);
                drawer.IsDrawing = true;
            }
        }
        void DrawBox_ShapeMouseUp(object sender, MouseEventArgs e)
        {
            drawer.IsDrawing = false;
            shapesManager.CurrentShapeCreator.AddPoint(e.X, e.Y);

            var shape = shapesManager.CurrentShapeCreator.Create(
                drawer.Pen.Width,
                penColorBox.BackColor,
                brushColorBox.BackColor,
                fillToolStripButton.Checked);

            if (shape != null)
            {
                bitmapContainer.Bitmap = bitmapContainer.BitmapBuffer;
                drawer.Graphics = Graphics.FromImage(bitmapContainer.Bitmap);

                shapesManager.AddShape(shape);
                drawer.Paint(shape);
                drawBox.Image = bitmapContainer.Bitmap;
            }
            shapesManager.CurrentShapeCreator.ResetPoints();
        }

        //Изменение цвета пера
        private void PenColorBox_Click(object sender, EventArgs e)
        {
            penColorDialog.Color = penColorBox.BackColor;
            penColorDialog.ShowDialog();

            penColorBox.BackColor = penColorDialog.Color;

            drawer.Pen.Color = penColorBox.BackColor;
        }

        //Изменение цвета кисти
        private void BrushColorBox_Click(object sender, EventArgs e)
        {
            brushColorDialog.Color = brushColorBox.BackColor;
            brushColorDialog.ShowDialog();

            brushColorBox.BackColor = brushColorDialog.Color;

            drawer.Brush = new SolidBrush(brushColorBox.BackColor);
        }

        //Изменение толщины пера
        private void PenWidthField_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(penWidthField.Text, out int width))
                {
                    if (width > 0)
                    {
                        drawer.Pen.Width = width;
                        e.SuppressKeyPress = true;

                        drawBox.Focus();

                        return;
                    }
                }

                penWidthField.Text = toolsManager.Drawer.Pen.Width.ToString();
                MessageBox.Show("Некорректное значение толщины кисти", "Ошибка", 
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Включение\отключение заполнения фигур
        private void FillToolStripButton_Click(object sender, EventArgs e)
        {
            fillToolStripButton.Checked = !fillToolStripButton.Checked;

            if (fillToolStripButton.Checked)
            {
                fillToolStripButton.Image = Properties.Resources._checked;
            }
            else
            {
                fillToolStripButton.Image = Properties.Resources.cross;
            }
        }

        // Открытие файла
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetProgramData(new SaveLoadSystem().Load(openFileDialog1.FileName));
                    drawBox.Image = bitmapContainer.Bitmap;
                    penColorBox.BackColor = drawer.Pen.Color;
                    penWidthField.Text = drawer.Pen.Width.ToString();

                    brushColorBox.BackColor = ((SolidBrush)drawer.Brush).Color;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Сохранение файла
        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {                  
                    new SaveLoadSystem().Save(GetProgramData(), saveFileDialog1.FileName);
                }
            }
            else
            {
                MessageBox.Show("Нечего сохранять", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        ProgramData GetProgramData()
        {
            return new ProgramData(
                shapesManager.Shapes,
                shapesManager.CurrentShapeNode.Value,
                bitmapContainer.Bitmap.Size,
                toolsManager.Drawer.Pen.Color,
                toolsManager.Drawer.Pen.Width,
                ((SolidBrush)toolsManager.Drawer.Brush).Color
                );
        }

        void SetProgramData(ProgramData programData)
        {
            shapesManager.Shapes = new LinkedList<Shape>(programData.shapes);
            shapesManager.CurrentShapeNode = ShapesManager.Instance.Shapes.First;
            for (int i = 0; i < programData.currentShapeIndex; i++)
            {
                shapesManager.CurrentShapeNode = ShapesManager.Instance.CurrentShapeNode.Next;
            }

            bitmapContainer.Bitmap = new Bitmap(programData.drawingFieldSize.Width, programData.drawingFieldSize.Height);
            toolsManager.Drawer.Graphics = Graphics.FromImage(BitmapContainer.Instance.Bitmap);
            toolsManager.Drawer.Graphics.Clear(Color.White);
            shapesManager.RedrawShapes();

            toolsManager.Drawer.Pen.Color = programData.penColor;
            toolsManager.Drawer.Pen.Width = programData.penWidth;
            toolsManager.Drawer.Brush = new SolidBrush(programData.brushColor);
        }

        void SetupBitmap(int width, int height)
        {
            bitmapContainer.Bitmap = new Bitmap(width, height);
            drawer.Graphics = Graphics.FromImage(bitmapContainer.Bitmap);

            drawer.Graphics.Clear(Color.White);

            shapesManager.ResetShapes();

            drawBox.Image = bitmapContainer.Bitmap;
        }

        // Вызов формы для создания области рисования
        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageSizeForm imageSizeForm = new ImageSizeForm();
            if (imageSizeForm.ShowDialog() == DialogResult.OK)
            {
                SetupBitmap(imageSizeForm.WidthResult, imageSizeForm.HeightResult);
            }
        }

        // Отмена отрисовки последней фигуры (или прекращение рисования, если оно в процессе)
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                drawer.Graphics.Clear(Color.White);
                if (drawer.IsDrawing)
                {
                    drawer.IsDrawing = false;
                    shapesManager.CurrentShapeCreator.ResetPoints();

                    shapesManager.RedrawShapes();
                }
                else
                {
                    shapesManager.Undo();
                }
                drawBox.Image = bitmapContainer.Bitmap;
            }
        }

        // Повтор отрисовки последней отменённой фигуры (или прекращение рисования, если оно в процессе)
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bitmapContainer.Bitmap != null)
            {
                if (drawer.IsDrawing)
                {
                    drawer.Graphics.Clear(Color.White);
                    shapesManager.CurrentShapeCreator.ResetPoints();
                    drawer.IsDrawing = false;

                    shapesManager.RedrawShapes();
                }
                else
                {
                    shapesManager.Redo();
                }

                drawBox.Image = bitmapContainer.Bitmap;
            }
        }

        private void pluginImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openDLLDialog.ShowDialog() == DialogResult.OK)
            {
                var plugins = pluginImporter.Import(openDLLDialog.FileName);
                int loadedPlugins;
                if (plugins == null)
                {
                    MessageBox.Show($"Плагин с заданным именем уже существует", "Сообщение", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    if ((loadedPlugins = SetupPlugins(plugins)) > 0)
                    {
                        MessageBox.Show($"Успешно загружено {loadedPlugins} плагинов", "Сообщение", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Не удалось загрузить ни одного плагина", "Сообщение", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
