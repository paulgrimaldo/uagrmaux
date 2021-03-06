unit uPersona;

interface

type
  Persona=class
    private
        nombre: String;
        ci: String;
    public
        constructor crear;
        procedure SetNombre(n:String);
        procedure SetCi(c: String);
        function GetNombre: String;
        function GetCi: String;
        function ToStr: String;

        procedure VotarPorCsi;

end;

implementation

  constructor  Persona.crear;
  begin
    nombre:='';
    ci:='';
  end;

  procedure Persona.SetNombre(n: String);
  begin
       nombre:=n;
  end;

  function Persona.GetNombre:String;
  begin
       Result:=nombre;
  end;

  procedure Persona.SetCi(c: String);
  begin
       ci:=c;
  end;

  function Persona.GetCi:String;
  begin
       Result:=ci;
  end;

  procedure Persona.VotarPorCsi;
  begin
    Writeln('Estoy votando por CSI');
  end;


  function Persona.ToStr:String;
  begin
    Result:='Persona(nombre='+nombre+',ci='+ci+')';
  end;

end.
