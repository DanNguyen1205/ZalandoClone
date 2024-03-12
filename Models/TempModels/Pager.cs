namespace ZaunShop.Models.TempModels
{
    public class Pager
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }

        //How many items in a page
        public int PageSize { get; private set; }

        //The amount of pages in total
        public int TotalPages { get; private set;}
        public int StartPage { get; private set; }
        public int EndPage { get; private set;}

        public Pager()
        {
            
        }

        public Pager(int totalItems, int page, int pageSize=10)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems/(decimal)pageSize);
            int currentPage = page;
            
            int startPage = currentPage - 5;
            int endPage = currentPage + 4;

            //In case that our start page is less than 0. We wanna set our start page to 1 and endpage to 10.
            if(startPage <= 0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }

            //In case our endpage is over the total ammount of pages. We basically wanna set our end page to the total and start page - 9 of that value.
            if(endPage > totalPages)
            {
                endPage = totalPages;
                if(endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.StartPage = startPage;
            this.EndPage = endPage;
        }
    }
}
