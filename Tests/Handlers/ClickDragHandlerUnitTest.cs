using Microsoft.VisualStudio.TestTools.UnitTesting;
using Presentation.Handlers;

namespace Tests
{
    [TestClass]
    public class ClickDragHandlerUnitTest
    {
        [TestMethod]
        public void Should_MouseMove()
        {
            object sender = null;
            System.Windows.Forms.MouseEventArgs e = null;
            ClickAndDragHandler.MouseMove(sender,e);

            int actualLeftControl = ClickAndDragHandler.Left;
            int actualTopControl = ClickAndDragHandler.Top;
            Assert.AreEqual(100, actualLeftControl);
            Assert.AreEqual(100, actualTopControl);
        }
    }
}
