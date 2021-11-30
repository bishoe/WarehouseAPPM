//using PagedList;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WarehouseAPPM.Classes;

//namespace WarehouseAPPM.Screen
//{
//    public partial class SearchWareHouse : Form
//    {
//        public SearchWareHouse()
//        {
//            InitializeComponent();
//        }
//        int pageNumber = 0;
//        IPagedList<Warehouse_Store> list;
//        public async Task<IPagedList<Warehouse_Store>> GetpagedListAsync(int pageNumber = 1, int pageSize = 10)
//        {
//            return await Task.Factory.StartNew(() =>
//            {
//                using (WarehouseEntities db = new WarehouseEntities())
//                {
//                    return db.Warehouse_Store.OrderBy(p => p.StoreId).ToPagedList(pageNumber, pageSize);
//                }
//            });

//        }
//        private async void SearchWareHouse_Load(object sender, EventArgs e)
//        {
//            list = await GetpagedListAsync();
//            BtnPrevious.Enabled = list.HasPreviousPage;
//            BtnNext.Enabled = list.HasNextPage;
//            dataGridView1.DataSource = list.ToList();
//            LBLPaheNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
//        }

//        private async void BtnNext_Click(object sender, EventArgs e)
//        {
//            if (list.HasNextPage)
//            {
//                list = await GetpagedListAsync(++pageNumber);
//                BtnPrevious.Enabled = list.HasPreviousPage;
//                BtnNext.Enabled = list.HasNextPage;
//                dataGridView1.DataSource = list.ToList();
//                LBLPaheNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
//            }

//        }

//        private async void BtnPrevious_Click(object sender, EventArgs e)
//        {
//            if (list.HasPreviousPage)
//            {
//                list = await GetpagedListAsync(--pageNumber);
//                BtnPrevious.Enabled = list.HasPreviousPage;
//                BtnNext.Enabled = list.HasNextPage;
//                dataGridView1.DataSource = list.ToList();
//                LBLPaheNumber.Text = string.Format("Page {0}/{1}", pageNumber, list.PageCount);
//            }
//        }
//    }
//}
