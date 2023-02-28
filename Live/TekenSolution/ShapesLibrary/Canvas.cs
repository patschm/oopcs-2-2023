
namespace ShapesLibrary
{
    public class Canvas
    {
        private List<Figuur> figuren = new List<Figuur>();

        public void Add(Figuur figure)
        {
            figuren.Add(figure);
            Refresh();
        }
        public void Refresh()
        {
            Console.Clear();
            foreach(Figuur fig in figuren)
            {
                fig.Teken();
            }
        }
    }
}
