unit Sumatorias;

interface

uses Math;

function Ejercicio1(n: Integer): Integer;
function Ejercicio2(n: Integer): Integer;

implementation

function Ejercicio1(n: Integer): Integer;
var
  x, y, z, sf, c: Integer;
begin
  x := -1;
  y := 1;
  c := 1;
  sf := 0;
  while c <= n do
  begin
    z := x + y;
    x := y;
    y := z;
    sf := sf + z;

    c := c + 1;
  end;

  Result := sf;
end;

function Ejercicio2(n: Integer): Integer;
var
  s1, s2, sf, x, a, c, p: Integer;
  sw: Boolean;
begin
  sf := 0;
  p := 3;
  s2 := 0;
  s1 := 1;
  x := 1;
  c := 1;
  a := 1;
  sw := True;

  while x <= n do
  begin
    if sw = True then
    begin
      s1 := s1 * a;
      a := a + 1;
      sf := sf + s1;
    end
    else
    begin
      s2 := Round(Power(2, p));
      p := p + 1;
      sf := sf + s2;
    end;

    c := c + 1;
    if c = 7 then
    begin
      c := 1;
      sw := Not sw;
    end;

    x := x + 1;
  end;

  Result := sf;
end;

end.
