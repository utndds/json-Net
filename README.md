# json-Net
Como parsear un Json con .NET

## Dependencias
- NewtonSoft Json

## Contexto
Quiero convertir un Json en una lista de personas que tiene atributos como nombre, peso, entre otros y una direccion, siendo Persona y Direccion clases de mi dominio.

## Aclaraciones
- Se uso una clase estatica intermedia/adaptadora llamada Parser ya que segun el POO si un dia queremos usar otra tecnologia/modulo distinto como parser el resto del programa no se tendria que enterar de este cambio (ver principios SOLID)
- No se catchearon errores en ningun momento para denotar que .NET no te obliga a hacerlo (a diferencia de Java)

## Explicacion
La "magia" principal se encuentra en esta parte 
```csharp
List<Persona> listaPersonas = JsonConvert.DeserializeObject<JObject>(json).Value<JArray>("personas").ToObject<List<Persona>>();
```
en donde...

```csharp
DeserializeObject<JObject>(json)
// Indica que quiero convertir el Json al tipo JObject para poder manipularlo con la propia libreria
```

```csharp
Value<JArray>("personas")
// Indica que quiero convertir especificamente a un JArray lo que se encuentre bajo la key "personas" 
// que segun mi modelo es un Array de Json justamente. 
```

```csharp    
ToObject<List<Persona>>()
// Indica que quiero convertir a ese Array a una lista compuesta de objetos Persona
```

