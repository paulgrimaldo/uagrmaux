<?php


class Grupo extends AbstractModel
{
    public $id;
    public $nombre;
    public $cursoMateriaId;


    public function __construct($id, $nombre, $cursoMateriaId)
    {
        $this->id = $id;
        $this->nombre = $nombre;
        $this->cursoMateriaId = $cursoMateriaId;
    }

    public function getSaveSql($db)
    {
        $sql = $db->prepare("INSERT INTO grupos (nombre, curso_materia_id) values(?, ?)");
        $sql->bindParam(1, $this->nombre, PDO::PARAM_STR, 50);
        $sql->bindParam(2, $this->cursoMateriaId, PDO::PARAM_INT);

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
        $req = $db->query('SELECT * FROM grupos');
        return $req->fetchAll();
    }

    public function getAlumnosEmails()
    {
        $db = Db::getInstance();
        $sql = 'SELECT a.email FROM alumnos a JOIN alumnos_grupos ag on a.id=ag.alumno_id where ag.grupo_id="' . $this->id . '"';
        $req = $db->query($sql);
        return $req->fetchAll();
    }
}
