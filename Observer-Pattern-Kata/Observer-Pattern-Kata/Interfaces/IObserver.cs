using Observer_Pattern_Kata.Implemntations;

namespace Observer_Pattern_Kata.Interfaces
{
    public interface IObserver
    {
        public User UserEntity { get; set; }
        void update(ISubject subject); // Captures Updates only, Observer should never change the state of the Subject!!!
    }
}