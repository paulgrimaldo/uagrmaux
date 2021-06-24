unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.Menus, Vcl.StdCtrls, Math;

type
  TForm1 = class(TForm)
    TxtNum: TEdit;
    TxtResult: TEdit;
    MainMenu1: TMainMenu;
    Ejercicios1: TMenuItem;
    Eliminarprimeryultimodigito1: TMenuItem;
    Mayorposicionesimpares1: TMenuItem;
    procedure Eliminarprimeryultimodigito1Click(Sender: TObject);
    procedure Mayorposicionesimpares1Click(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.Eliminarprimeryultimodigito1Click(Sender: TObject);
var
  n, d, nu, i: Integer;
begin
   nu:=0;
   i:=0;

   n:=StrToInt(TxtNum.Text);

   n:=n div 10;

    while n>10 do
    begin
       d:= n mod 10;
       n:= n div 10;

       nu:=nu + d * Round(Power(10,i));
       i:=i+1;
    end;

    TxtResult.Text :=  IntToStr(nu)  ;
end;

procedure TForm1.Mayorposicionesimpares1Click(Sender: TObject);
var
  n, d, m, i: Integer;
begin
    n:=StrToInt(TxtNum.Text);

    m:= n mod 10;
    i:=1;

    while n>0 do
    begin
      d:= n mod 10;
      n:= n div 10;

      if i mod 2  =1  then
      begin
        if d>=m then
        begin
          m:=d;
        end;
      end;
      i:=i+1;
    end;

     TxtResult.Text :=  IntToStr(m)  ;
end;

end.
