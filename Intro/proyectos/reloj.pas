program reloj; 

uses
  crt, dos, graph, SysUtils, ureloj;


var
  h, m, s, c: Word;
  h2, m2, s2, c2: Word;


begin
  IniciarModoGrafico;
  GetTime(h, m, s, c);
  DibujarEsfera;
  DibujarHorero(h);
  DibujarMinutero(m);
  DibujarSegundero(s);
  setwritemode(xorput);
  repeat 
    GetTime(h2, m2, s2, c2);
    if s2 <> s then
      begin
        BorrarSegundero(s);
        DibujarSegundero(s2);
        s := s2;
      end ;
     if m2 <> m then
       begin
         BorrarMinutero(m);
         DibujarMinutero(m2);
         m := m2;
       end; 
     if h2 <> h then
     begin
         BorrarHorero(h);
         DibujarHorero(h2);
         h := h2;
     end;
    
  until keypressed;
  FinalizarModoGrafico;
  writeln('Fin');
end.