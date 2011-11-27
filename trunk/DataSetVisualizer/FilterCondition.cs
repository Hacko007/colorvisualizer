using System;
using System.Data;

namespace Hackovic.VisualStudio
{
  /// <summary>
  ///   Contains information needed for filtering a <see cref = "DataTable" />
  /// </summary>
  public class FilterCondition
  {
    /// <summary>
    ///   Gets or sets <see cref = "DataTable" /> that should be filtered
    /// </summary>
    public DataTable TargetTable { get; set; }

    /// <summary>
    ///   Gets or sets <see cref = "DataColumn" />'s used for 
    ///   filtering data on <see cref = " TargetTable" />
    /// </summary>
    public DataColumn[] FilterOnColumns { get; set; }

    /// <summary>
    ///   Gets or sets source row with data used for filter
    /// </summary>
    public DataRow SourceRow { get; set; }

    /// <summary>
    ///   Gets or sets <see cref = "DataColumn" />'s used to exctract data
    ///   from <see cref = "SourceRow" />
    /// </summary>
    public DataColumn[] SourceColumns { get; set; }

    /// <summary>
    ///   Gets or sets indication if <see cref = "FilterCondition" /> is 
    ///   filter on cell value (true) or filter on relation (false)
    /// </summary>
    public bool IsFilterOnValue { get; set; }

    /// <summary>
    ///   String represenation of this object
    /// </summary>
    /// <returns>Filter that can be used on <see cref = "TargetTable" /></returns>
    public override string ToString()
    {
      string select = "";
      int i = 0;
      foreach (DataColumn column in FilterOnColumns)
      {
        if (column.DataType == typeof (int)
            || column.DataType == typeof (bool)
            || column.DataType == typeof (float)
            || column.DataType == typeof (decimal)
            || column.DataType == typeof (double))
        {
          select += (select == "") ? "" : " AND ";
          select += string.Format("({0} = {1})", column.ColumnName, SourceRow[SourceColumns[i]]);
        }
        else if (column.DataType == typeof (string)
                 || column.DataType == typeof (DateTime))
        {
          select += (select == "") ? "" : " AND ";
          select += string.Format("({0} = '{1}')", column.ColumnName, SourceRow[SourceColumns[i]]);
        }
        i++;
      }
      return select;
    }
  }
}