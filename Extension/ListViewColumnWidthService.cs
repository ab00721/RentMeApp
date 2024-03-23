using System.Windows.Forms;

namespace RentMeApp.Extension
{
    public static class ListViewColumnWidthService
    {
        public static ListView Distribute(ListView givenListView)
        {
            if (givenListView == null)
            {
                return new ListView();
            }

            int columnCount = givenListView.Columns.Count;
            int columnWidth = givenListView.Width / columnCount;

            foreach (ColumnHeader column in givenListView.Columns)
            {
                column.Width = columnWidth;
            }

            return givenListView;
        }
    }
}
