# Fit the column width and row height based on content size

This example demonstrates how to adjust the columns and rows based on content size in [WPF GridControl](https://help.syncfusion.com/wpf/gridcontrol/overview).

### Autofit row height

`GridControl` provides the support to auto fit the row height based on content of the cells using [ResizeRowsToFit](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridModel.html#Syncfusion_Windows_Controls_Grid_GridModel_ResizeRowsToFit_Syncfusion_Windows_Controls_Grid_GridRangeInfo_Syncfusion_Windows_Controls_Grid_GridResizeToFitOptions_) method which accepts the following parameters,

* [GridRangeInfo](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridRangeInfo.html) - Specifies the range where `GridControl` auto fits the rows based on the cell content.
* [GridResizeToFitOptions](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridResizeToFitOptions.html) - Specifies the auto fit settings to customize the auto fit behavior.

``` csharp
//To auto fit single row 2,
grid.Model.ResizeRowsToFit(GridRangeInfo.Row(2), GridResizeToFitOptions.NoShrinkSize);

//To auto fit range of rows from 3 to 6,
grid.Model.ResizeRowsToFit(GridRangeInfo.Rows(3,6), GridResizeToFitOptions.NoShrinkSize);

//To auto fit range of cell's(including Covered cells) row height,
this.grid.Model.ResizeRowsToFit(GridRangeInfo.Cells(1, 1, 2, 2),GridResizeToFitOptions.IncludeCellsWithinCoveredRange);

//To auto fit entire grid's row height,
this.grid.Model.ResizeRowsToFit(GridRangeInfo.Table(), GridResizeToFitOptions.None);
```
### Autofit column width

`GridControl` provides the support to auto fit the column width based on content of the cells using [ResizeColumnsToFit](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridModel.html#Syncfusion_Windows_Controls_Grid_GridModel_ResizeColumnsToFit_Syncfusion_Windows_Controls_Grid_GridRangeInfo_Syncfusion_Windows_Controls_Grid_GridResizeToFitOptions_) method which accepts the following parameters,

* [GridRangeInfo](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridRangeInfo.html) - Specifies the range where GridControl auto fits the columns based on the cell content.
* [GridResizeToFitOptions](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridResizeToFitOptions.html) - Specifies the auto fit settings to customize the auto fit behavior.

``` csharp
//To auto fit single column 2,
grid.Model.ResizeColumnsToFit(GridRangeInfo.Col(2), GridResizeToFitOptions.NoShrinkSize);

//To auto fit range of Columns from 3 to 6,
grid.Model.ResizeColumnsToFit(GridRangeInfo.Cols(3,6), GridResizeToFitOptions.NoShrinkSize);

//To auto fit range of cell's(including Covered cells) column width,
this.grid.Model.ResizeColumnsToFit(GridRangeInfo.Cells(1, 1, 2, 2),GridResizeToFitOptions.IncludeCellsWithinCoveredRange);

//To auto fit entire grid's column width,
this.grid.Model.ResizeColumnsToFit(GridRangeInfo.Table(), GridResizeToFitOptions.None);
```

### Autofit Cells based on Wrap Text

To autofit the cell’s height based on the applied wrap text, need to use [ResizeRowsToFit](https://help.syncfusion.com/cr/wpf/Syncfusion.Windows.Controls.Grid.GridModel.html#Syncfusion_Windows_Controls_Grid_GridModel_ResizeRowsToFit_Syncfusion_Windows_Controls_Grid_GridRangeInfo_Syncfusion_Windows_Controls_Grid_GridResizeToFitOptions_) method.

``` csharp
this.grid.Model[2, 2].TextWrapping = TextWrapping.Wrap;
this.grid.Model.ResizeRowsToFit(GridRangeInfo.Cell(2, 2),GridResizeToFitOptions.NoShrinkSize);
```