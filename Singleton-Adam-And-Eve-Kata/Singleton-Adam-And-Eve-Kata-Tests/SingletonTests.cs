using Singleton_Adam_And_Eve_Kata;
using System.Reflection;

public class SingletonTests
{
    [Fact]
    public void Adam_is_unique()
    {
        Adam adam = Adam.GetInstance();
        Adam anotherAdam = Adam.GetInstance();

        Assert.True(adam is Adam);
        Assert.Equal(adam, anotherAdam);
    }

    [Fact]
    public void Adam_is_unique_and_cannot_be_overriden()
    {
        Assert.True(typeof(Adam).IsSealed);
    }

    [Fact]
    public void Adam_is_a_human()
    {
        Assert.True(Adam.GetInstance() is Human);
    }

    [Fact]
    public void Adam_is_a_male()
    {
        Assert.True(Adam.GetInstance() is Male);
    }

    [Fact]
    public void Eve_is_unique_and_created_from_a_rib_of_adam()
    {
        Adam adam = Adam.GetInstance();
        Eve eve = Eve.GetInstance(adam);
        Eve anotherEve = Eve.GetInstance(adam);

        Assert.True(eve is Eve);
        Assert.Equal(eve, anotherEve);

        //GetInstance() is the only static method on Eve
        Assert.Equal(1, typeof(Eve).GetMethods().Where(x => x.IsStatic).Count());

        //Eve has no public or internal constructor
        Assert.False(typeof(Eve).GetConstructors(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
            .Any(x => x.IsPublic | x.IsAssembly));

        //Eve cannot be overridden
        Assert.True(typeof(Eve).IsSealed);
    }

    [Fact]
    public void Eve_can_only_be_create_of_a_rib_of_adam()
    {
        Assert.Throws<ArgumentNullException>(() => Eve.GetInstance(null));
    }

    [Fact]
    public void Eve_is_a_human()
    {
        Assert.True(Eve.GetInstance(Adam.GetInstance()) is Human);
    }

    [Fact]
    public void Eve_is_a_female()
    {
        Assert.True(Eve.GetInstance(Adam.GetInstance()) is Female);
    }

    [Fact]
    public void Reproduction_always_result_in_a_male_or_female()
    {
        Assert.True(typeof(Human).IsAbstract);
    }

}