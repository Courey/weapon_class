// Courey Elliott
//video game weapon class example

using System;
using System.Collections.Generic;

public class Weapon
{
	public string WeaponName { get; set; }
	private int mRange;
	public int Range 
	{ 
		get{ return mRange;}
		set
		{
			if(value >= 0)
				mRange = value;
			else
				throw new Exception("Range must be greater than -1.");
		}
	} 

	private int mDamage;
	public int Damage 
	{ 
		get { return mDamage;}
		set
		{
			if (value >= 0)
				mDamage = value;
			else
				throw new Exception ("Damage must be 0 or greater.");
		}
	} 

	public override string ToString() 
	{
		return WeaponName + " has a range of " + Range + " and a damage of " + Damage + ". \n";
	}

	public Weapon (string aWeaponName = "", int aRange = 0, int aDamage = 0)
	{
		WeaponName = aWeaponName;
		Range = aRange;
		Damage = aDamage;
	}
}

public class Spell: Weapon
{
	private int mSkillPoints;
	public int SkillPoints 
	{
		get
		{ return mSkillPoints;}
		set {
			if (value >= 0) {
				mSkillPoints = value;
			}
			else 
			{
				throw new Exception ("Spells require 0 or more skill points. \n");
			}
		}
	}
		public Spell(string aWeaponName = "", int aRange = 0, int aDamage = 0, int aSkillPoints = 0):base(aWeaponName, aRange, aDamage)
		{
			SkillPoints = aSkillPoints;
		}

	public override string ToString() 
	{
		return base.ToString()+ "you need " + SkillPoints + " skill points required to cast this spell. \n";
		Console.WriteLine ("spell to string");
	}
}

public class MeleeWeapon: Weapon
{
	public MeleeWeapon(string aWeaponName = "", int aRange = 1, int aDamage = 0):base(aWeaponName, aRange, aDamage)
	{
		if (aRange != 1)
			Console.WriteLine ("Range must be 1 for Melee Weapon.");
		else 
		{}
	}
	public override string ToString() 
	{
		return base.ToString () + " Range is always going to be "+ base.Range + ". \n";

	}
}

public class Projectile: Weapon
{
	private string mAmmo;
	public string Ammo
	{
		get
		{ return mAmmo;}
		set
		{
			if (WeaponName == "Pea Shooter")
				mAmmo = "BB's";
			else if (WeaponName == "Long Bow")
				mAmmo = "Arrows";
			else if (WeaponName == "Waterballoon Launcher")
				mAmmo = "Water Balloons";
			else 
				throw new Exception("Invalid Projectile Weapon.");
		}
	}
	 
	public Projectile(string aWeaponName = "", int aRange = 0, int aDamage = 0, string aAmmo = ""):base(aWeaponName, aRange, aDamage)
	{
		Ammo = aAmmo;
	}
	public override string ToString() 
	{
		return base.ToString () + " This weapon uses " + Ammo + " for amunition. \n";
	}
}

class MainClass
{
	public static void Main (string[] args)
	{
		List<Weapon> aList = new List <Weapon> ();
		aList.Add(new Spell ("Bazinga", 20, 50, 5));
		aList.Add (new Spell ("Storm", 40, 30, 3));
		aList.Add (new Spell ("Abracadabra", 20, 20, 2));
		aList.Add (new MeleeWeapon ("Rat Flail", 1, 10));
		aList.Add (new MeleeWeapon ("Foot", 1, 5));
		aList.Add (new MeleeWeapon ("Sonic Screwdriver", 1, 20));
		aList.Add (new Projectile ("Pea Shooter", 20, 15, "ammo"));
		aList.Add (new Projectile ("Long Bow", 30, 20, "ammo"));
		aList.Add (new Projectile ("Waterballoon Launcher", 35, 10, "ammo"));

		foreach (Weapon x in aList)
		{
			Console.WriteLine(x);
		}
		Console.ReadLine ();
	}
}
/* My output:
*******************************************************************

Bazinga has a range of 20 and a damage of 50. 
you need 5 skill points required to cast this spell. 

Storm has a range of 40 and a damage of 30. 
you need 3 skill points required to cast this spell. 

Abracadabra has a range of 20 and a damage of 20. 
you need 2 skill points required to cast this spell. 

Rat Flail has a range of 1 and a damage of 10. 
 Range is always going to be 1. 

Foot has a range of 1 and a damage of 5. 
 Range is always going to be 1. 

Sonic Screwdriver has a range of 1 and a damage of 20. 
 Range is always going to be 1. 

Pea Shooter has a range of 20 and a damage of 15. 
 This weapon uses BB's for amunition. 

Long Bow has a range of 30 and a damage of 20. 
 This weapon uses Arrows for amunition. 

Waterballoon Launcher has a range of 35 and a damage of 10. 
 This weapon uses Water Balloons for amunition. . 
 
 */
