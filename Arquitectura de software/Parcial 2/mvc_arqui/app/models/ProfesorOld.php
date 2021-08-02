<?php

class ProfesorOld
{
    public $id;
    public $nombre;
    public $codigo;


    public function __construct($id, $nombre, $codigo)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->codigo = $codigo;
    }


    public static function guardar($nombre, $codigo)
    {
        $db = Db::getInstance();
        $sql = $db->prepare("INSERT INTO profesores (nombre,codigo) values(?,?)");
        $sql->bindParam(1, $nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $codigo, PDO::PARAM_STR, 50);
        $req = $sql->execute();
        if ($req) {
            return true;
        } else {
            return false;
        }
    }

    public static function exists($codigo)
    {
        $db = Db::getInstance();
        $sql = 'SELECT * FROM profesores WHERE codigo="' . $codigo . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT * FROM profesores');
        return $req->fetchAll();
    }
}