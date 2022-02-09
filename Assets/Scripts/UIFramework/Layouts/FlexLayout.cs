using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace UIFramework
{
    public class FlexLayout : LayoutGroup
    {
        public enum FitType
        {
            Uniform,
            Width,
            Height,
            FixedRow,
            FixedColumns
        }

        [SerializeField] private Vector2 cellSize;
        [SerializeField] private Vector2 spacing;
        [SerializeField] private FitType fitType;
        
        
        private int rows;
        private int columns;
        private bool fitX;
        private bool fitY;


        public override void CalculateLayoutInputHorizontal()
        {
            base.CalculateLayoutInputHorizontal();


            if (fitType == FitType.Width || fitType == FitType.Height || fitType == FitType.Uniform) {
                //  Figure out number of rows and columsn by finding the square root of the the number of children in the transform.
                float sqrRt = Mathf.Sqrt(transform.childCount);
                rows = Mathf.CeilToInt(sqrRt);
                columns = Mathf.CeilToInt(sqrRt);
            }


            if (fitType == FitType.Width || fitType == FitType.FixedColumns) {
                rows = Mathf.CeilToInt(transform.childCount / (float)columns);

            }

            if (fitType == FitType.Height || fitType == FitType.FixedRow) {
                columns = Mathf.CeilToInt(transform.childCount / (float)rows);
            }




            //  Get width and height of container to know how much space to work with.
            float parentWidth = rectTransform.rect.width;
            float parentHeight = rectTransform.rect.height;

            //  Define a size for the children with the info we now have.
            float cellWidth = (parentWidth / (float)columns) - ((spacing.x / (float)columns) * (columns - 1)) - (padding.left / (float)columns) - (padding.right / (float)columns);
            float cellHeight = (parentHeight / (float)rows) - ((spacing.y / (float)rows) * (rows - 1)) - (padding.top / (float)rows) - (padding.bottom / (float)rows);

            cellSize.x = fitX ? cellWidth : cellSize.x;
            cellSize.y = fitY ? cellHeight : cellSize.y;

            //  keep a count
            int columnCount = 0;
            int rowCount = 0;

            for (int i = 0; i < rectChildren.Count; i++) {
                rowCount = i / columns;
                columnCount = i % columns;

                var item = rectChildren[i];

                var xPos = (cellSize.x * columnCount) + (spacing.x * columnCount) + padding.left;
                var yPos = (cellSize.y * rowCount) + (spacing.y * rowCount) + padding.top;

                SetChildAlongAxis(item, 0, xPos, cellSize.x);
                SetChildAlongAxis(item, 1, yPos, cellSize.y);

            }
            
            
            
            
            
        }





        public override void CalculateLayoutInputVertical(){}

        public override void SetLayoutHorizontal(){}
        
        public override void SetLayoutVertical(){}
            
    }
}