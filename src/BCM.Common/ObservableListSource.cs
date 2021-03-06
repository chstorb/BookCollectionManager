﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCM.Common
{
    using System.Collections;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Data.Entity;

    /// <summary>
    /// ObservableListSource class
    /// The ObservableListSource class enables two-way data binding and sorting. The class extends 
    /// ObservableCollection<T> and adds an explicit implementation of IListSource. The GetList() 
    /// method of IListSource is implemented to return an IBindingList implementation that stays in 
    /// sync with the ObservableCollection. The IBindingList implementation generated by 
    /// ToBindingList supports sorting. The ToBindingList extention method is defined in the 
    /// EntityFramework assembly.
    /// (http://blogs.msdn.com/b/adonet/archive/2011/02/16/ef-feature-ctp5-code-first-and-winforms-databinding.aspx)
    /// (http://msdn.microsoft.com/en-us/data/jj682076.aspx)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ObservableListSource<T> : ObservableCollection<T>, IListSource
        where T : class
    {
        private IBindingList _bindingList;

        bool IListSource.ContainsListCollection
        {
            get { return false; }
        }

        IList IListSource.GetList()
        {
            return _bindingList ?? (_bindingList = this.ToBindingList());
        }
    }
}
