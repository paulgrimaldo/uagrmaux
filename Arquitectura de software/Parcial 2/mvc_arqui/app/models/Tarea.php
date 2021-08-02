<?php

class Tarea extends AbstractModel
{
    public $id;
    public $nombre;
    public $valorNota;
    public $cursoMateriaId;

    public function __construct($id, $nombre, $valorNota, $cursoMateriaId)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->valorNota = $valorNota;
        $this->cursoMateriaId = $cursoMateriaId;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO tareas (nombre,valor_nota, curso_materia_id) values(?,?,?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->valorNota, PDO::PARAM_INT);
        $sql->bindParam(3, $this->cursoMateriaId, PDO::PARAM_INT);

        return $sql;
    }

    public function setModelId()
    {
        $db = Db::getInstance();
        $this->id = $db->lastInsertId();
    }

    public static function all()
    {
        $db = DB::getInstance();
        $req = $db->query('SELECT * FROM tareas');
        return $req->fetchAll();
    }
}