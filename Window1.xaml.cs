#region Copyright Syncfusion Inc. 2001 - 2020
// Copyright Syncfusion Inc. 2001 - 2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace ResizeToFitDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Documents;
    using System.Windows.Input;
    using System.Windows.Media;
    using System.Windows.Media.Imaging;
    using System.Windows.Navigation;
    using System.Windows.Shapes;
    using Syncfusion.Windows.Shared;
    using Syncfusion.Windows.Controls.Grid;
    using Syncfusion.Windows.GridCommon;

    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : ChromelessWindow
    {
        public Window1()
        {
            InitializeComponent();
            this.InitGrid();
        }

        private void InitGrid()
        {
            
            this.grid.Model.RowCount = 35;
            this.grid.Model.ColumnCount = 25;
           
            for (int i = 1; i < 35; i++)
            {
                for (int j = 1; j < 25; j++)
                {
                    this.grid.Model[i, j].CellValue = string.Format("Row{0} Col{1} Row{0} Col{1} ", i, j);
                }
            }           
            this.grid.Model.CoveredCells.Add(new Syncfusion.Windows.Controls.Cells.CoveredCellInfo(4, 5, 6, 7));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.grid.Model.ResizeRowsToFit(GridRangeInfo.Rows(3,5), GridResizeToFitOptions.NoShrinkSize|GridResizeToFitOptions.IncludeCellsWithinCoveredRange);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.grid.Model.ResizeColumnsToFit(GridRangeInfo.Cols(6,8), GridResizeToFitOptions.NoShrinkSize|GridResizeToFitOptions.IncludeCellsWithinCoveredRange);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.grid.Model.ResizeRowsToFit(GridRangeInfo.Cells(1, 1, 2, 2),GridResizeToFitOptions.NoShrinkSize);
            this.grid.Model.ResizeColumnsToFit(GridRangeInfo.Cells(1, 1, 2, 2), GridResizeToFitOptions.NoShrinkSize);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.grid.Model.ResizeColumnsToFit(GridRangeInfo.Table(), GridResizeToFitOptions.NoShrinkSize);
            this.grid.Model.ResizeRowsToFit(GridRangeInfo.Table(), GridResizeToFitOptions.NoShrinkSize);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            this.grid.Model[8, 4].CellValue = "Checking\nWrap\nText\nin the\nGridControl";
            this.grid.Model[8, 4].TextWrapping = TextWrapping.Wrap;
            this.grid.Model.ResizeRowsToFit(GridRangeInfo.Cell(8, 4), GridResizeToFitOptions.IncludeHeaders);
        }
    }
}
