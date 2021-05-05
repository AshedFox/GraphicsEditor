
namespace GraphicsEdit
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);


        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penColorDialog = new System.Windows.Forms.ColorDialog();
            this.toolsPanel = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.shapesTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.penTool = new System.Windows.Forms.ToolStripDropDownButton();
            this.linePenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapePenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.penWidthLabel = new System.Windows.Forms.ToolStripLabel();
            this.penWidthField = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.penColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.penColorBox = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.brushColorLabel = new System.Windows.Forms.ToolStripLabel();
            this.brushColorBox = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.brushColorDialog = new System.Windows.Forms.ColorDialog();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.drawBox = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.currentToolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.locationStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openDLLDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolsPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1110, 34);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.pluginExportToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.createToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Открыть";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Сохранить";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // pluginExportToolStripMenuItem
            // 
            this.pluginExportToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pluginExportToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.pluginExportToolStripMenuItem.Name = "pluginExportToolStripMenuItem";
            this.pluginExportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pluginExportToolStripMenuItem.Text = "Импорт плагинов";
            this.pluginExportToolStripMenuItem.Click += new System.EventHandler(this.pluginImportToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.правкаToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.правкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.undoToolStripMenuItem.Text = "Отменить";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 8F);
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.Z)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.redoToolStripMenuItem.Text = "Повторить";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // penColorDialog
            // 
            this.penColorDialog.AnyColor = true;
            this.penColorDialog.FullOpen = true;
            // 
            // toolsPanel
            // 
            this.toolsPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.toolsPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolsPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolsPanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.shapesTool,
            this.toolStripSeparator4,
            this.penTool,
            this.toolStripSeparator1,
            this.penWidthLabel,
            this.penWidthField,
            this.toolStripSeparator3,
            this.penColorLabel,
            this.penColorBox,
            this.toolStripSeparator2,
            this.brushColorLabel,
            this.brushColorBox,
            this.toolStripButton2,
            this.fillToolStripButton});
            this.toolsPanel.Location = new System.Drawing.Point(0, 0);
            this.toolsPanel.Margin = new System.Windows.Forms.Padding(3);
            this.toolsPanel.Name = "toolsPanel";
            this.toolsPanel.Padding = new System.Windows.Forms.Padding(0);
            this.toolsPanel.Size = new System.Drawing.Size(189, 526);
            this.toolsPanel.Stretch = true;
            this.toolsPanel.TabIndex = 4;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(188, 6);
            // 
            // shapesTool
            // 
            this.shapesTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.rectToolStripMenuItem,
            this.polygonToolStripMenuItem});
            this.shapesTool.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.shapesTool.ForeColor = System.Drawing.SystemColors.Control;
            this.shapesTool.Image = global::GraphicsEdit.Properties.Resources.circle;
            this.shapesTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.shapesTool.Name = "shapesTool";
            this.shapesTool.Size = new System.Drawing.Size(188, 24);
            this.shapesTool.Text = "Фигуры";
            this.shapesTool.ToolTipText = "Выберите фигуру";
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lineToolStripMenuItem.Text = "Прямая";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.LineToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Image = global::GraphicsEdit.Properties.Resources.circle;
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.circleToolStripMenuItem.Text = "Круг";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.CircleToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Image = global::GraphicsEdit.Properties.Resources.rectangle;
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.rectToolStripMenuItem.Text = "Прямоугольник";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.RectToolStripMenuItem_Click);
            // 
            // polygonToolStripMenuItem
            // 
            this.polygonToolStripMenuItem.Image = global::GraphicsEdit.Properties.Resources.triangle;
            this.polygonToolStripMenuItem.Name = "polygonToolStripMenuItem";
            this.polygonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.polygonToolStripMenuItem.Text = "Многоугольник";
            this.polygonToolStripMenuItem.Click += new System.EventHandler(this.PolygonToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(188, 6);
            // 
            // penTool
            // 
            this.penTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linePenToolStripMenuItem,
            this.shapePenToolStripMenuItem});
            this.penTool.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.penTool.ForeColor = System.Drawing.SystemColors.Control;
            this.penTool.Image = global::GraphicsEdit.Properties.Resources.ink_pen;
            this.penTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penTool.Name = "penTool";
            this.penTool.Padding = new System.Windows.Forms.Padding(2);
            this.penTool.Size = new System.Drawing.Size(188, 28);
            this.penTool.Text = "Перо";
            // 
            // linePenToolStripMenuItem
            // 
            this.linePenToolStripMenuItem.Name = "linePenToolStripMenuItem";
            this.linePenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.linePenToolStripMenuItem.Text = "Ломаная";
            this.linePenToolStripMenuItem.Click += new System.EventHandler(this.LinePenToolStripMenuItem__Click);
            // 
            // shapePenToolStripMenuItem
            // 
            this.shapePenToolStripMenuItem.Name = "shapePenToolStripMenuItem";
            this.shapePenToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.shapePenToolStripMenuItem.Text = "Фигура";
            this.shapePenToolStripMenuItem.Click += new System.EventHandler(this.ShapePenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // penWidthLabel
            // 
            this.penWidthLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.penWidthLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.penWidthLabel.Name = "penWidthLabel";
            this.penWidthLabel.Size = new System.Drawing.Size(188, 17);
            this.penWidthLabel.Text = "Толщина пера";
            // 
            // penWidthField
            // 
            this.penWidthField.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.penWidthField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penWidthField.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.penWidthField.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.penWidthField.MaxLength = 3;
            this.penWidthField.Name = "penWidthField";
            this.penWidthField.Size = new System.Drawing.Size(168, 27);
            this.penWidthField.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.penWidthField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PenWidthField_KeyDown);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(188, 6);
            // 
            // penColorLabel
            // 
            this.penColorLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.penColorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.penColorLabel.Name = "penColorLabel";
            this.penColorLabel.Size = new System.Drawing.Size(188, 17);
            this.penColorLabel.Text = "Цвет пера";
            // 
            // penColorBox
            // 
            this.penColorBox.BackColor = System.Drawing.Color.Black;
            this.penColorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.penColorBox.ForeColor = System.Drawing.Color.Black;
            this.penColorBox.Image = ((System.Drawing.Image)(resources.GetObject("penColorBox.Image")));
            this.penColorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.penColorBox.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.penColorBox.Name = "penColorBox";
            this.penColorBox.Padding = new System.Windows.Forms.Padding(8);
            this.penColorBox.Size = new System.Drawing.Size(168, 20);
            this.penColorBox.Click += new System.EventHandler(this.PenColorBox_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(188, 6);
            // 
            // brushColorLabel
            // 
            this.brushColorLabel.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.brushColorLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.brushColorLabel.Name = "brushColorLabel";
            this.brushColorLabel.Size = new System.Drawing.Size(188, 17);
            this.brushColorLabel.Text = "Цвет кисти";
            // 
            // brushColorBox
            // 
            this.brushColorBox.BackColor = System.Drawing.Color.White;
            this.brushColorBox.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.brushColorBox.ForeColor = System.Drawing.Color.Black;
            this.brushColorBox.Image = ((System.Drawing.Image)(resources.GetObject("brushColorBox.Image")));
            this.brushColorBox.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brushColorBox.Margin = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.brushColorBox.Name = "brushColorBox";
            this.brushColorBox.Padding = new System.Windows.Forms.Padding(8);
            this.brushColorBox.Size = new System.Drawing.Size(168, 20);
            this.brushColorBox.Click += new System.EventHandler(this.BrushColorBox_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(188, 6);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.Font = new System.Drawing.Font("Verdana", 7.8F, System.Drawing.FontStyle.Bold);
            this.fillToolStripButton.ForeColor = System.Drawing.SystemColors.Control;
            this.fillToolStripButton.Image = global::GraphicsEdit.Properties.Resources.cross;
            this.fillToolStripButton.ImageTransparentColor = System.Drawing.Color.BlueViolet;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Padding = new System.Windows.Forms.Padding(2);
            this.fillToolStripButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fillToolStripButton.Size = new System.Drawing.Size(188, 28);
            this.fillToolStripButton.Text = "Заполнять фигуры";
            this.fillToolStripButton.Click += new System.EventHandler(this.FillToolStripButton_Click);
            // 
            // brushColorDialog
            // 
            this.brushColorDialog.AnyColor = true;
            this.brushColorDialog.FullOpen = true;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoSize = true;
            this.mainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.toolsPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 34);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1110, 526);
            this.mainPanel.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.drawBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(189, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(921, 526);
            this.panel1.TabIndex = 2;
            // 
            // drawBox
            // 
            this.drawBox.BackColor = System.Drawing.Color.Transparent;
            this.drawBox.Location = new System.Drawing.Point(5, 5);
            this.drawBox.Margin = new System.Windows.Forms.Padding(5);
            this.drawBox.Name = "drawBox";
            this.drawBox.Size = new System.Drawing.Size(0, 0);
            this.drawBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.drawBox.TabIndex = 1;
            this.drawBox.TabStop = false;
            this.drawBox.MouseLeave += new System.EventHandler(this.DrawBox_MouseLeave);
            this.drawBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawBox_MouseMove);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentToolStatusLabel,
            this.locationStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // currentToolStatusLabel
            // 
            this.currentToolStatusLabel.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentToolStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.currentToolStatusLabel.Margin = new System.Windows.Forms.Padding(5);
            this.currentToolStatusLabel.Name = "currentToolStatusLabel";
            this.currentToolStatusLabel.Size = new System.Drawing.Size(68, 20);
            this.currentToolStatusLabel.Text = "status";
            // 
            // locationStripStatusLabel1
            // 
            this.locationStripStatusLabel1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Bold);
            this.locationStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.locationStripStatusLabel1.Name = "locationStripStatusLabel1";
            this.locationStripStatusLabel1.Size = new System.Drawing.Size(86, 24);
            this.locationStripStatusLabel1.Text = "x: -; y: -";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image file|*.myimage";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Image file|*.myimage";
            // 
            // openDLLDialog
            // 
            this.openDLLDialog.Filter = "dynamic library|*.dll";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1110, 590);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolsPanel.ResumeLayout(false);
            this.toolsPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawBox)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColorDialog penColorDialog;
        private System.Windows.Forms.ToolStrip toolsPanel;
        private System.Windows.Forms.ToolStripLabel penWidthLabel;
        private System.Windows.Forms.ToolStripTextBox penWidthField;
        private System.Windows.Forms.ToolStripLabel brushColorLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton brushColorBox;
        private System.Windows.Forms.ToolStripLabel penColorLabel;
        private System.Windows.Forms.ToolStripButton penColorBox;
        private System.Windows.Forms.ColorDialog brushColorDialog;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem pluginExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polygonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel currentToolStatusLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox drawBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel locationStripStatusLabel1;
        private System.Windows.Forms.ToolStripDropDownButton penTool;
        private System.Windows.Forms.ToolStripMenuItem linePenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shapePenToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openDLLDialog;
        private System.Windows.Forms.ToolStripDropDownButton shapesTool;
    }
}

