using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.WindowsFormsApplication
{
	public class BookSelectedEventArgs: EventArgs
	{
        #region Fields
	    
        public int BookId { get; set; }
        
        #endregion Fields

        #region Constructor 

		public BookSelectedEventArgs()
		{
		}

		public BookSelectedEventArgs(int bookId)
		{
			this.BookId = bookId;
		}
        
        #endregion Constructors
	};
}
