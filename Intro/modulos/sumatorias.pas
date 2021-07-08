unit sumatorias; 

interface


uses
  Math;

function Ejercicio3(n: Integer) : Integer;
function Ejercicio6(n: Integer) : Integer;

implementation

function Ejercicio3(n: Integer) : Integer;

var
  sf, s1, s2, a, c: Integer;
  sw: Boolean;


begin
  s1 := 1;
  a := 3;
  s2 := 5;
  c := 1;
  sw := true;
  sf := 0;
  while c <= n do 
    begin
      if sw = true then
        begin
          sf := sf + s1;
          s1 := s1 + a;
          a := a + 2;
        end 
      else 
        begin
          sf := sf + s2;
          s2 := s2 + 5;
        end;
      sw := not sw;
      c := c + 1;
    end;
  Ejercicio3 := sf;
end; 
function Ejercicio6(n: Integer) : Integer;

var
  sf, p,t, c: Integer;


begin
  p := 0;
  c := 1;
  sf := 0;
  t:=0;
  while c <= n do 
    begin
    t:=3*Round(Power(2,p));
    p:=p+1;
    sf:=sf+t;
    c:=c+1;
    end;
  Ejercicio6:=sf;
end; 
end.