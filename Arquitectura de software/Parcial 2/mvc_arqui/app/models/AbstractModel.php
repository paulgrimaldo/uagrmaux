<?php

abstract class AbstractModel
{

    public function guardar(): bool
    {
        $db = Db::getInstance();
        $sql = $this->getSaveSql($db);
        $req = $sql->execute();
        if ($req) {
            $this->setModelId();
            return true;
        } else {
            return false;
        }
    }

    abstract function getSaveSql($db);

    abstract function setModelId();
}