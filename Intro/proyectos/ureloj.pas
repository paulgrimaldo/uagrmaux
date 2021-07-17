unit ureloj; 

interface


uses
  crt, graph;


var
  x0, y0: Integer;


const
  ts = 250;
  tm = 250;
  th = 200;
  te = 250;
  pi = 3.1416;

procedure IniciarModoGrafico;
procedure FinalizarModoGrafico;
procedure DibujarSegundero(s: byte);
procedure BorrarSegundero(s: byte);
procedure DibujarMinutero( m :byte);
procedure BorrarMinutero(m: byte);
procedure DibujarHorero(h:byte);
procedure BorrarHorero(h:byte);
procedure DibujarEsfera;
implementation

procedure IniciarModoGrafico;

var
  gd, gm: Integer;


begin
  gd := detect;
  initgraph(gd, gm, '');
  x0 := getMaxX div 2;
  y0 := getMaxY div 2;
end; 
procedure FinalizarModoGrafico;

begin
  closegraph;
end; 
procedure DibujarSegundero(s: byte);

var
  x, y: Integer;
  alfa: Real;


begin
  alfa := 90 - s * 6;
  setcolor(green);
  moveto(x0, y0);
  x := trunc(ts * cos(alfa * pi / 180));
  y := trunc(ts * sin(alfa * pi / 180));
  lineto(x0 + x, y0 - y);
end; 
 
procedure BorrarSegundero(s: byte);

begin
  DibujarSegundero(s);
end; 

procedure DibujarMinutero(m:byte);
var
  x, y: Integer;
  beta: Real;


begin
  beta := 90 - m * 6;
  setcolor(red);
  moveto(x0, y0);
  x := trunc(tm * cos(beta * pi / 180));
  y := trunc(tm * sin(beta * pi / 180));
  lineto(x0 + x, y0 - y);
end; 

procedure BorrarMinutero(m:byte);
begin
  DibujarMinutero(m);
end;

procedure DibujarHorero(h: byte);
var
  x, y: Integer;
  gama: Real;

begin
  gama := 90 -( h+20) * 30;
  setcolor(white);
  moveto(x0, y0);
  x := trunc(th * cos(gama * pi / 180));
  y := trunc(th * sin(gama * pi / 180));
  lineto(x0 + x, y0 - y);
end;

procedure BorrarHorero(h:byte);
begin
  DibujarHorero(h);
end;

procedure DibujarEsfera;
begin
  circle(x0,y0,te);
end;
end.