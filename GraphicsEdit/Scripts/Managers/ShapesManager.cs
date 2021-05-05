using GraphicsEdit;
using Scripts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedLib;


namespace Shapes
{
    public class ShapesManager : IUndoRedo
    {
        #region Singleton

        private static readonly Lazy<ShapesManager> instance =
            new Lazy<ShapesManager>(() => new ShapesManager());

        #endregion

        public static ShapesManager Instance => instance.Value;

        private ShapeCreator currentShapeCreator;

        public ShapeCreator CurrentShapeCreator
        {
            get => currentShapeCreator;
            set => currentShapeCreator = value;
        }

        private LinkedListNode<Shape> currentShapeNode;

        private LinkedList<Shape> shapes;

        public LinkedList<Shape> Shapes
        {
            get => shapes;
            set => shapes = value;
        }
        public LinkedListNode<Shape> CurrentShapeNode { get => currentShapeNode; set => currentShapeNode = value; }

        public ShapesManager()
        {
            Shapes = new LinkedList<Shape>();

            Shapes.AddFirst(new LinkedListNode<Shape>(null));
            currentShapeNode = Shapes.First;

            currentShapeCreator = new CircleCreator();
        }

        /// <summary>
        /// Добавить фигуру в список всех фигур
        /// </summary>
        public void AddShape(Shape shape)
        {
            RemoveOutdatedRedos();

            Shapes.AddLast(shape);

            currentShapeNode = currentShapeNode.Next;
        }


        //Удалить устаревшие redo-фигуры
        public void RemoveOutdatedRedos()
        {
            var linkedListNode = currentShapeNode.Next;
            LinkedListNode<Shape> buffer;

            while (linkedListNode != null)
            {
                buffer = linkedListNode;
                linkedListNode = linkedListNode.Next;

                Shapes.Remove(buffer);
            }
        }

        //Сбросить список фигур
        public void ResetShapes()
        {
            Shapes = new LinkedList<Shape>();
            Shapes.AddFirst(new LinkedListNode<Shape>(null));
            currentShapeNode = Shapes.First;
        }


        /// <summary>
        /// Отменить отрисовку фигуры
        /// </summary>
        public void Undo()
        {
            if (currentShapeNode != Shapes.First)
            {
                currentShapeNode = currentShapeNode.Previous;

                RedrawShapes();
            }
        }

        /// <summary>
        /// Повторить отрисовку отменённой фигуры
        /// </summary>
        public void Redo()
        {
            if (currentShapeNode != Shapes.Last)
            {
                currentShapeNode = currentShapeNode.Next;

                ToolsManager.Instance.Drawer.Paint(currentShapeNode.Value);
            }
        }

        /// <summary>
        /// Перерисовать все фигуры
        /// </summary>
        public void RedrawShapes()
        {
            LinkedListNode<Shape> linkedListNode = shapes.First;

            while (linkedListNode != currentShapeNode)
            {
                linkedListNode = linkedListNode.Next;

                ToolsManager.Instance.Drawer.Paint(linkedListNode.Value);
            }
        }
    }
}