namespace StarCraft_State_Pattern_Kata.Interfaces
{
    public interface IUnitState
    {
        bool CanMove { get; set; }
        int Damage { get; set; }
    }
}