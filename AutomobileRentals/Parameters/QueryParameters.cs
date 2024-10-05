namespace AutomobileRentals.Parameters
{
    public class QueryParameters
    {
        private int _pageSize = 10;
        public int PageNumber { get; set; }
        public int StartIndex { get; set; }
        public int PageSize
        {
            get { return _pageSize; }
            set { _pageSize = value; }
        }
    }
}
