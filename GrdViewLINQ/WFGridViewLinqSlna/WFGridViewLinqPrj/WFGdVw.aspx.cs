using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WFGridViewLinqPrj
{
    public partial class WFGdVw : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<CLSPROPOER> erLst = new List<CLSPROPOER>()
            {
                new CLSPROPOER {_rno=1001, _sname="x5", _m1=56.5, _m2=63 },
                new CLSPROPOER {_rno=1002, _sname="y5", _m1=65.5, _m2=93 },
                new CLSPROPOER {_rno=1003, _sname="z5", _m1=78, _m2=33 }

            };
            GridView1.DataSource = erLst;
            GridView1.DataBind();
        }

    }
}
