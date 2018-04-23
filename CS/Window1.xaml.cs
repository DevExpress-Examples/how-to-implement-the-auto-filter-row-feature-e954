using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using DevExpress.Xpf.Grid;
using DevExpress.Data.Filtering;

namespace AutoFilterRow {

    public partial class Window1 : Window {
        List<TestData> list;

        public Window1() {
            InitializeComponent();

            list = new List<TestData>();
            for (int i = 0; i < 1000; i++) {
                list.Add(new TestData() { Text = Guid.NewGuid().ToString(), Number = i });
            }
            grid.ItemsSource = list;
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int Number { get; set; }
    }

}
