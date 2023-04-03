

classDiagram

class Bolillero{
    +cantidad: int
}


class AlAzar{
    <<interface>>
    +numeros: int
}


class Random{

}

class Random <|-- class AlAzar


