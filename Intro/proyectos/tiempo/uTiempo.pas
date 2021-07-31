unit uTiempo;
{$mode OBJFPC }
interface
uses sysutils;
type
  Tiempo=class
     private
         h:byte;
         m:byte;
         s:byte;
      public
         constructor create;
         procedure SetHora(hh:byte);
         procedure SetMinuto(mm:byte);
         procedure SetSegundo(ss:byte);
         property Hora:byte read h write SetHora;
         property Minuto:byte read m write SetMinuto;
         property Segundo:byte read s write SetSegundo;
         function ToStr:String;
         function ToSegundos():Cardinal;
         function ToMinutos():Integer;
         function Literal():String;
   end;
         
implementation
constructor Tiempo.Create;
begin
	h:=0;
	m:=0;
	s:=0;
end;
procedure Tiempo.SetHora(hh:byte);
begin
	if hh<24 then begin
		h:=hh;
	end else begin
	   raise Exception.Create('Error:dato no valido');
	end;
end;
procedure Tiempo.SetMinuto(mm:byte);
begin
	if mm<60 then begin
		m:=mm;
	end else begin
		raise Exception.Create('Error:dato no val');
	end;
end;
procedure Tiempo.SetSegundo(ss:byte);
begin
	if ss<60 then begin
		s:=ss;
	end else begin
		raise Exception.Create('Error:dato no val');
	end;		
end;
function Tiempo.ToStr:string;
begin
	Tostr:=inttostr(h)+':'+inttostr(m)+':'+inttostr(s);
end;
function Tiempo.ToSegundos:Cardinal;
var resultado: Cardinal;
begin
	resultado:=h*3600+m*60+s;
	ToSegundos:=resultado;
end;	
function Tiempo.ToMinutos:Integer;
var r: Integer;
begin
	r:=h*60 + m;
	ToMinutos:=r;
end;
function Tiempo.Literal:String;
var r: String;
begin
	r:='Son las '+ inttostr(h) + ' con '+inttostr(m)+' minutos y '+inttostr(s)+' segundos';
	Literal:=r;
end;	
end.