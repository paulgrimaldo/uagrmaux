unit uFrutaVenenosa;
{$mode OBJFPC }
interface
  uses Sysutils;
type 
  FrutaVenenosa=class
    private 
      posx: Real;
      posy: Real;
      puntos: String;
      figura: String;
      color :String;
    public 
      constructor create;
      procedure SetPosx(xx:Real);
      procedure SetPosy(yy:Real);
      procedure SetPuntos(p: String);
      procedure SetFigura(f: String);
      procedure SetColor(c: String);
      function GetPosx:Real;
      function GetPosy:Real;
      function GetPuntos:String;
      function GetFigura:String;
      function GetColor: String;
      function ToStr:String;
      
      procedure Mostrar;
      procedure Borrar;
  end;    
implementation
  constructor FrutaVenenosa.create;
  begin
    posx:=0;
    posy:=0;
    puntos:='';
    figura:='';
    color:='';
  end;
  procedure FrutaVenenosa.SetPosx(xx:Real);
  begin
    posx:=xx;
  end;
  procedure FrutaVenenosa.SetPosy(yy:Real);
  begin
    posy:=yy;
  end;
  procedure FrutaVenenosa.SetPuntos(p:String);
  begin
    puntos:=p;
  end;
  procedure FrutaVenenosa.SetFigura(f:String);
  begin
    figura:=f;
  end;
  procedure FrutaVenenosa.SetColor(c:String);
  begin
    color:=c;
  end;
  function FrutaVenenosa.GetPosx:Real;
  begin
    GetPosx:=posx;
  end;
  function FrutaVenenosa.GetPosy:Real;
  begin
    GetPosy:=posy;
  end;
  function FrutaVenenosa.GetPuntos:String;
  begin
    GetPuntos:=puntos;
  end;
  function FrutaVenenosa.GetFigura:String;
  begin
    GetFigura:=figura;
  end;
  function FrutaVenenosa.GetColor:String;
  begin
    GetColor:=color;
  end;
  
  procedure FrutaVenenosa.Mostrar;
  begin
    WriteLn('Estoy mostrando');
  end;
  procedure FrutaVenenosa.Borrar;
  begin
    WriteLn('Estoy borrando');
  end;
  
  function FrutaVenenosa.ToStr:String;
  var cad:String;
  begin
    cad:=floattostr(posx) + ', '+ floattostr(posy)+ ', ' + puntos+', ' + figura+ ', ' + color;
    ToStr:=cad;
  end;
end.
