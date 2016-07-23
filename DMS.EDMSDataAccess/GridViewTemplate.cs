using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Media;
using System.Drawing;

namespace DMS.EDMSDataAccess
{
    /// <summary>
    /// Summary description for GridViewTemplate
    /// </summary>
    public class GridViewTemplate : ITemplate
    {

        //A variable to hold the type of ListItemType.

        ListItemType _templateType;



        //A variable to hold the column name.

        string _columnName;



        //Constructor where we define the template type and column name.

        public GridViewTemplate(ListItemType type, string colname)
        {

            //Stores the template type.

            _templateType = type;



            //Stores the column name.

            _columnName = colname;

        }



        void ITemplate.InstantiateIn(System.Web.UI.Control container)
        {

            switch (_templateType)
            {

                case ListItemType.Header:

                    //Creates a new label control and add it to the container.

                    Label lbl = new Label();            //Allocates the new label object.

                    lbl.Text = _columnName;             //Assigns the name of the column in the lable.

                    container.Controls.Add(lbl);        //Adds the newly created label control to the container.

                    break;



                case ListItemType.Item:

                    //Creates a new text box control and add it to the container.

                    TextBox tb1 = new TextBox();                            //Allocates the new text box object.

                    tb1.DataBinding += new EventHandler(tb1_DataBinding);   //Attaches the data binding event.

                    tb1.Columns = 20;
                    Color c = Color.FromArgb(231, 231, 255);
                    tb1.ForeColor = System.Drawing.Color.Navy;
                    tb1.BackColor = c;
                    //Creates a column with size 10.
                    container.Controls.Add(tb1);                            //Adds the newly created textbox to the container.

                    break;



                case ListItemType.EditItem:

                    //As, I am not using any EditItem, I didnot added any code here.
                    TextBox tb2 = new TextBox();                            //Allocates the new text box object.

                    tb2.DataBinding += new EventHandler(tb2_DataBinding);   //Attaches the data binding event.

                    tb2.Columns = 16;                                        //Creates a column with size 10.

                    container.Controls.Add(tb2);
                    break;



                case ListItemType.Footer:

                    CheckBox chkColumn = new CheckBox();

                    chkColumn.ID = "Chk" + _columnName;

                    container.Controls.Add(chkColumn);

                    break;

            }

        }


        void tb1_DataBinding(object sender, EventArgs e)
        {

            //TextBox txtdata = (TextBox)sender;
            TextBox txtdata = (TextBox)sender;
            GridViewRow container = (GridViewRow)txtdata.NamingContainer;

            object dataValue = DataBinder.Eval(container.DataItem, _columnName);

            if (dataValue != DBNull.Value)
            {

                txtdata.Text = dataValue.ToString();

            }

        }

        void tb2_DataBinding(object sender, EventArgs e)
        {

            //TextBox txtdata = (TextBox)sender;
            TextBox txtdata1 = (TextBox)sender;
            GridViewRow container = (GridViewRow)txtdata1.NamingContainer;

            object dataValue = DataBinder.Eval(container.DataItem, _columnName);

            if (dataValue != DBNull.Value)
            {

                txtdata1.Text = dataValue.ToString();

            }

        }

    }

}