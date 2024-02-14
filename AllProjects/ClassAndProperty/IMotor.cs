﻿

namespace ClassAndProperty;

internal interface IMotor
{
	public Color Renk { get; set; }
	public byte VitesSayisi { get; set; }
	public string YakitCinsi { get; set; }
	public void Git() => WriteLine("Gidiyorum");
	public void Dur() => WriteLine("Durdum");
	public void VitesDegis() => WriteLine("Vites Degistirdim");
	public void FarYak() => WriteLine("Farlari Yaktım");
}
