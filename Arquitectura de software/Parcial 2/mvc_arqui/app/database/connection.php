<?php


const DB_HOST = 'localhost';
const DB_NAME = 'arquimvc';
const DB_USER = 'root';
const DB_PASS = '';
/*define('DB_HOST', 'localhost');
define('DB_NAME', 'arquimvc');
define('DB_USER', 'root');
define('DB_PASS', '');*/
class Db
{
    private static $instance = NULL;

    private function __construct()
    {
    }

    public static function getInstance()
    {
        if (!isset(self::$instance)) {
            $pdo_options[PDO::ATTR_ERRMODE] = PDO::ERRMODE_EXCEPTION;
            $dsn = 'mysql:host=' . DB_HOST . ';dbname=' . DB_NAME . ';charset=utf8';
            self::$instance = new PDO($dsn . '', DB_USER, DB_PASS, $pdo_options);
        }
        return self::$instance;
    }
}