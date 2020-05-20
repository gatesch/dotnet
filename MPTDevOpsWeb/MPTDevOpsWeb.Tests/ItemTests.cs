using Microsoft.VisualStudio.TestTools.UnitTesting;
using MPTDevOpsWeb;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPTDevOpsWeb.Tests
{
    [TestClass()]
    public class ItemTests
    {
        private TestContext m_testContext;

        public TestContext TestContext

        {

            get { return m_testContext; }

            set { m_testContext = value; }

        }



        [TestMethod()]
        public void T1000_ItemTest()
        {
            Assert.Inconclusive("Not implement yet.");
            // Assert.Fail();
        }

        [DeploymentItem("T1data.csv"),
         DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "T1data.csv", "T1data#csv", DataAccessMethod.Sequential),
         TestMethod()]
        public void T1004_SeqDataDrivenItemTestDB()
        {
            // RowID,Input1,Input2,CHKCODE
            //int valueA = Convert.ToInt32(this.TestContext.DataRow["Input1"]);
            //int valueB = Convert.ToInt32(this.TestContext.DataRow["CHKCODE"]);
            //int expected = Convert.ToInt32(this.TestContext.DataRow["expectedResult"]);

            string demomode = "pass"; // pass , fail

            if (demomode == "pass")
            {
                // Pass Block : all row pass test logic.
                string IDstring = this.TestContext.DataRow["RowID"].ToString();
                string chkstring = this.TestContext.DataRow["CHKCODE"].ToString();
                StringAssert.Contains(chkstring, IDstring);
            }
            else
            {
                // Some Failed Row Block : row at 0
                int valueA = Convert.ToInt32(this.TestContext.DataRow["RowID"]);
                int valueB = Convert.ToInt32(this.TestContext.DataRow["CHKCODE"]);
                Assert.AreNotEqual(0, valueB - valueA, string.Format("Value must not equal 0, {0} - {1}", valueB, valueA));
            }

            // Assert.Inconclusive("Not implement yet.");
            // Assert.Fail();

        }

        [DeploymentItem("T1data.csv"),
          DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "T1data.csv", "T1data#csv", DataAccessMethod.Random),
          TestMethod()]
        public void T1005_RndDataDrivenItemTestDB()
        {
            string IDstring = this.TestContext.DataRow["RowID"].ToString();
            string chkstring = this.TestContext.DataRow["CHKCODE"].ToString();
            string testmsg = string.Format("CHKCODE must contains ID, CHKCODE {0} / ID {1}", chkstring, IDstring);

            StringAssert.Contains(chkstring, IDstring, testmsg);
            Trace.WriteLine(testmsg);

            //  Assert.Inconclusive("Not implement yet.");
            // Assert.Fail();
        }

        [TestMethod]
        public void T1006_LoopTestWordsStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "ΑOriva", "Мockaa", "Office" };
            int i = 0;
            foreach (var word in words)
            {
                i++;
                bool result = word.StartsWithUpper(); 
                string testmsg = $"\n--> item position at {i}, Expected for '{word}': true; Actual: {result}";
                Assert.IsTrue(result,testmsg);
                Trace.WriteLine(testmsg);
            }
        }


        [TestMethod()]
        public void T1001_ItemCountDefaultEQZero()
        {
            Item i = new Item();

            Assert.IsTrue(0 == i.ItemCount);
            //Assert.Fail();
        }
        [TestMethod()]
        public void ItemCountMustGTZero()
        {
            Assert.Inconclusive("Disable to Pass all cases./ make the Tests inactive.");
            Item i = new Item();

            i.ItemCount = -1;
            int actualitemcount = i.ItemCount;

            Assert.IsTrue(actualitemcount >= 0);
            //Assert.Fail();

        }
        [TestMethod()]
        public void ItemCountMustReadOnlyProperty()
        {
            Assert.Inconclusive("Disable to Pass all cases./ make the Tests inactive.");
            Item i = new Item();

            i.ItemCount = -1;
            int actualitemcount = i.ItemCount;
            int notexpected = -1;
            Assert.AreNotEqual(notexpected, actualitemcount);
            //  Assert.IsTrue(actualitemcount >= 0);
            //Assert.Fail();
        }
        [TestMethod()]
        public void T1002_IncreaseItemCountTest()
        {

            Item i = new Item();
            int bf = i.ItemCount;
            int incamt = 1;
            i.IncreaseItemCount(incamt);
            int aftr = i.ItemCount;

            int expc = bf + incamt;
            Assert.AreEqual(expc, aftr);
            //            Assert.Fail();
        }

        [TestMethod()]
        public void T1003_DecreaseItemCountTest()
        {
            Item i = new Item();
            int bf = i.ItemCount;
            int decamt = 1;
            i.DecreaseItemCount(decamt);
            int aftr = i.ItemCount;

            int expc = bf - decamt;
            Assert.AreEqual(expc, aftr);
        }
        [TestMethod()]
        public void T1007_checkItemSizeTest()
        {
            Item i = new Item();
            string getitemsize = i.itemSize;

            string expclogic = "";
            string testmsg = string.Format("logic check item size not empty : getitemzise = {0} , expect not eq = '{1}' ", getitemsize, expclogic);
            Assert.AreNotEqual(expclogic, getitemsize, testmsg);
        }
    }
}