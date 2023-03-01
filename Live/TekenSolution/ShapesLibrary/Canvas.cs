
namespace ShapesLibrary
{
    public class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Add(Figuur figure)
        {
            figuren.Add(figure);
        }
        public void Refresh(IDevice device)
        {
            foreach(Figuur fig in figuren)
            {
                fig.Teken(device);
            }
        }
    }
}
