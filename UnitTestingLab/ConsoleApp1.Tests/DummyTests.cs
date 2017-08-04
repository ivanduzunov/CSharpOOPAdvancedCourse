using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private const int AxeAttack = 10;
    private const int AxeDurability = 10;
    private const int DummyHp = 10;
    private const int DummyExp = 100;

    private Axe axe;
    private Dummy dummy;

    [SetUp]
    public void Testinit()
    {
        this.axe = new Axe(AxeAttack, AxeDurability);
        this.dummy = new Dummy(DummyHp, DummyExp);
    }

    [Test]
    public void DummyLosesHealthIfAtacked()
    {
        //Arrange
        axe = new Axe(10, 10);
        dummy = new Dummy(12, 10);

        //Act
        axe.Attack(dummy);

        //Assert
        Assert.AreEqual(2, dummy.Health);
    }
    [Test]
    public void DeadDummyThrowsExceptiojIfAtacked()
    {
        //Arrange
        Axe axe = new Axe(10, 10);
        Dummy dummy = new Dummy(0, 10);

        //Act
        var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));

        //Assert
        Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        Dummy dummy = new Dummy(0, 10);

        int exp = dummy.GiveExperience();

        Assert.AreEqual(10, exp, "Dead dummy gives exp!");
    }

    [Test]
    public void ActiveDummyCantGiveXP()
    {
        Dummy dummy = new Dummy(10, 10);

        var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());

        Assert.AreEqual(ex.Message, "Target is not dead.");
    }
}

