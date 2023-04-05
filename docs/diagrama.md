```mermaid
classDiagram

class Bolillero{
    +cantidad: int
}


class IAzar{
    <<interface>>
    +numeros: int
}


class Azar{

}

class Azar <|-- class AlAzar
```


