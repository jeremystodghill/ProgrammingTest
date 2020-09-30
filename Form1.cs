using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 6; i < 9; i++)
            {
                List<Models.Order> ord = CreateOrderData(i);
                foreach (Models.Order order in ord)
                {
                    int over50 = 0;
                    int over100 = 0;
                    int total = 0;

                    int points = 0;

                    foreach (Models.OrderItem item in order.OrderItems)
                    {
                        total += Convert.ToInt32(item.Price);
                    }
                    if (total > 99)
                    {
                        over50 = 50;
                    }
                    else if (total > 50)
                    {
                        over50 = total - 50;

                    }

                    if (total > 100)
                    {
                        over100 = total - 100;
                    }

                    points = over50 + (over100 * 2);
                    if (i == 6)
                    {
                        lblJune.Text = points.ToString();
                    }
                    if (i == 7)
                    {
                        lblJuly.Text = points.ToString();
                    }
                    if (i == 8)
                    {
                        lblAugust.Text = points.ToString();
                    }

                }
            }
        }

        private List<Models.Order> CreateOrderData(int Month)
        {
            if (Month == 6)
            {
                //first month orderlist
                List<Models.Order> orderlist = new List<Models.Order>();


                //first month orders

                //order 1
                Models.Order ord = new Models.Order();
                DateTime dt = DateTime.Now;
                dt.AddMonths(-3);
                ord.OrderDate = dt;
                ord.Id = 1;

                //order1 orderitems
                List<Models.OrderItem> orderitems = new List<Models.OrderItem>();

                //add order item to order1
                Models.OrderItem orderItem = new Models.OrderItem();
                orderItem.Id = 1;
                orderItem.Price = 120.00;
                orderitems.Add(orderItem);

                //add order item 2 to order
                Models.OrderItem orderItem2 = new Models.OrderItem();
                orderItem2.Id = 2;
                orderItem2.Price = 40.00;
                orderitems.Add(orderItem2);

                //add the order items to order1
                ord.OrderItems = orderitems;

                //add order1 to orderlist
                orderlist.Add(ord);

                //order 2
                Models.Order ord2 = new Models.Order();
                DateTime dt3 = DateTime.Now;
                dt3.AddMonths(-3);
                ord.OrderDate = dt3;
                ord.Id = 2;

                //order2 orderitems
                List<Models.OrderItem> orderitems2 = new List<Models.OrderItem>();

                //add order item3 to orderlist2
                Models.OrderItem orderItem3 = new Models.OrderItem();
                orderItem3.Id = 1;
                orderItem3.Price = 110;
                orderitems2.Add(orderItem3);

                //add orderitem4 to orderlist2
                Models.OrderItem orderItem4 = new Models.OrderItem();
                orderItem4.Id = 2;
                orderItem4.Price = 30;
                orderitems2.Add(orderItem4);

                //add the order items to the order2
                ord2.OrderItems = orderitems2;

                //add order 2 to order list
                orderlist.Add(ord);


                return orderlist;
            }

            else if (Month == 7)
            {
                //second month orderlist
                List<Models.Order> orderlist = new List<Models.Order>();

                ////second month orders

                //order 1
                Models.Order ord = new Models.Order();
                DateTime dt = DateTime.Now;
                dt.AddMonths(-2);
                ord.OrderDate = dt;
                ord.Id = 1;

                //order1 orderitems
                List<Models.OrderItem> orderitems = new List<Models.OrderItem>();

                //add order item to order1
                Models.OrderItem orderItem = new Models.OrderItem();
                orderItem.Id = 1;
                orderItem.Price = 105;
                orderitems.Add(orderItem);

                //add order item 2 to order
                Models.OrderItem orderItem2 = new Models.OrderItem();
                orderItem2.Id = 2;
                orderItem2.Price = 30;
                orderitems.Add(orderItem2);

                //add the order items to order1
                ord.OrderItems = orderitems;

                //add order1 to orderlist
                orderlist.Add(ord);

                //order 2
                Models.Order ord2 = new Models.Order();
                DateTime dt3 = DateTime.Now;
                dt3.AddMonths(-2);
                ord.OrderDate = dt3;
                ord.Id = 2;

                //order2 orderitems
                List<Models.OrderItem> orderitems2 = new List<Models.OrderItem>();

                //add order item3 to orderlist2
                Models.OrderItem orderItem3 = new Models.OrderItem();
                orderItem3.Id = 1;
                orderItem3.Price = 80;
                orderitems2.Add(orderItem3);

                //add orderitem4 to orderlist2
                Models.OrderItem orderItem4 = new Models.OrderItem();
                orderItem4.Id = 2;
                orderItem4.ItemId = 2;
                orderItem4.Price = 200;
                orderitems2.Add(orderItem4);

                //add the order items to the order2
                ord2.OrderItems = orderitems2;

                //add order 2 to order list
                orderlist.Add(ord);

                return orderlist;

            }

            else if (Month == 8)
            {
                //third month orderlist
                List<Models.Order> orderlist = new List<Models.Order>();

                ////second month orders

                //order 1
                Models.Order ord = new Models.Order();
                DateTime dt = DateTime.Now;
                dt.AddMonths(-1);
                ord.OrderDate = dt;
                ord.Id = 1;

                //order1 orderitems
                List<Models.OrderItem> orderitems = new List<Models.OrderItem>();

                //add order item to order1
                Models.OrderItem orderItem = new Models.OrderItem();
                orderItem.Id = 1;
                orderItem.Price = 110;
                orderitems.Add(orderItem);

                //add order item 2 to order
                Models.OrderItem orderItem2 = new Models.OrderItem();
                orderItem2.Id = 2;
                orderItem2.Price = 52;
                orderitems.Add(orderItem2);

                //add the order items to order1
                ord.OrderItems = orderitems;

                //add order1 to orderlist
                orderlist.Add(ord);

                //order 2
                Models.Order ord2 = new Models.Order();
                DateTime dt3 = DateTime.Now;
                dt3.AddMonths(-1);
                ord.OrderDate = dt3;
                ord.Id = 2;

                //order2 orderitems
                List<Models.OrderItem> orderitems2 = new List<Models.OrderItem>();

                //add order item3 to orderlist2
                Models.OrderItem orderItem3 = new Models.OrderItem();
                orderItem3.Id = 1;
                orderItem3.Price = 86;
                orderitems2.Add(orderItem3);

                //add orderitem4 to orderlist2
                Models.OrderItem orderItem4 = new Models.OrderItem();
                orderItem4.Id = 2;
                orderItem4.Price = 183;
                orderitems2.Add(orderItem4);

                //add the order items to the order2
                ord2.OrderItems = orderitems2;

                //add order 2 to order list
                orderlist.Add(ord);

                return orderlist;
            }
            else
            {
                List<Models.Order> orderlist = new List<Models.Order>();
                return orderlist;
            }



         








        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
