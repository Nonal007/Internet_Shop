﻿using System;
using MaterialDesignThemes.Wpf;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;


namespace Internet_Shop.NewSec
{
    public class ItemMenu
    {
        public ItemMenu(string header, List<SubItem> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }

        public string Header { get; private set; }
        public PackIconKind Icon { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public UserControl Screen { get; private set; }

    }
}
