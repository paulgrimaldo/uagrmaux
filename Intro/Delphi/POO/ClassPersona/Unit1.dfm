object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Form1'
  ClientHeight = 414
  ClientWidth = 835
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object TxtNombre: TEdit
    Left = 176
    Top = 72
    Width = 121
    Height = 21
    TabOrder = 0
    Text = 'TxtNombre'
  end
  object TxtCi: TEdit
    Left = 176
    Top = 112
    Width = 121
    Height = 21
    TabOrder = 1
    Text = 'TxtCi'
  end
  object Edit3: TEdit
    Left = 456
    Top = 80
    Width = 233
    Height = 65
    TabOrder = 2
    Text = 'Edit3'
  end
  object BtnCrear: TButton
    Left = 264
    Top = 184
    Width = 75
    Height = 25
    Caption = 'Crear'
    TabOrder = 3
    OnClick = BtnCrearClick
  end
end
