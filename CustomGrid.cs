using System;
using System.Windows;
using DevExpress.Xpf.Grid;

namespace DXSample2
{
    public class CustomGrid : GridControl
    {
        public static readonly DependencyProperty GroupingAndSummariesProperty = DependencyProperty.Register(
            "GroupingAndSummaries",
            typeof(Boolean),
            typeof(CustomGrid),
            new PropertyMetadata(null));

        public Boolean GroupingAndSummaries
        {
            get { return (Boolean)this.GetValue(GroupingAndSummariesProperty); }
            set
            {
                this.SetValue(GroupingAndSummariesProperty, value);
                ((TableView)View).ShowGroupPanel = value;
                ((TableView)View).AllowGrouping = value;
                ((TableView)View).ShowTotalSummary = value;
            }
        }
    }
}