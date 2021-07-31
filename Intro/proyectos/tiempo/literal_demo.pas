program tiempo_demo;
uses uTiempo;
var t: Tiempo;

b: String;
segundos: Cardinal;
begin
	
	
	t:=Tiempo.create;
	t.SetHora(50);
	t.SetMinuto(59);
	t.SetSegundo(59);
	
	b:=t.ToStr();
	
	WriteLn(b);
	segundos:=t.ToSegundos;
	WriteLn(segundos);
	WriteLn(t.ToMinutos);
	WriteLn(t.Literal);
end.