# Proyecto: Taller de Mejores Prácticas en el Aplicativo de Automóviles

**Pepito** es un Ingeniero de Software Junior en **Codificando Con Patrones Cía. Ltda.** Se le ha encargado la tarea de completar los requerimientos funcionales del aplicativo de automóviles al que la empresa da soporte.

## Requerimientos

1. **Implementar los métodos de agregar vehículos (add Mustang y add Explorer) en el Home Page**  
   - El programador anterior implementó un patrón repositorio que contiene los métodos CRUD para el repositorio de automóviles; sin embargo, el equipo de QA ha reportado que no funciona como se espera.

2. **Probar funcionalidad sin dependencia de la base de datos**  
   - El equipo de base de datos ha informado que el esquema no está listo, por lo que es necesario buscar una forma de probar la funcionalidad sin guardar en la base de datos. Posteriormente, se integrará la funcionalidad de base de datos.

3. **Agregar propiedades por defecto**  
   - El equipo de negocio ha solicitado agregar el **año actual** y 20 propiedades más por defecto que se solicitarán en el siguiente sprint.  
   - Es necesario implementar un patrón de diseño que permita agregar estas propiedades de manera extensible para minimizar los cambios en futuros sprints.

4. **Extensibilidad para nuevos modelos de vehículos**  
   - Se planea agregar un nuevo modelo. El Arquitecto de Software prevé que se introducirán más modelos en el futuro. Por lo tanto, se sugiere implementar un **Factory Method**.  

   **Características del nuevo modelo:**
   - **Color**: Red
   - **Marca**: Ford
   - **Modelo**: Escape

## Resumen del Taller

1. Analizar el código propuesto:  
   El código base está disponible en el siguiente repositorio:  
   [https://github.com/juanjoleong/Best-Practices-Udla-Workshop](https://github.com/juanjoleong/Best-Practices-Udla-Workshop)  

   Los alumnos deberán identificar qué **mejores prácticas, principios SOLID y patrones de diseño** pueden implementarse para mejorar la solución.

2. Documentación:  
   Elaborar un documento explicativo con las mejores prácticas propuestas, diseño UML de los patrones a implementar y una justificación técnica.

3. Implementación:  
   Clonar el repositorio base e implementar los patrones propuestos. Subir la solución al repositorio personal de Git con el código comentado.

---

## Forma de Trabajo

- **Trabajo individual**

---

## Especificaciones de Entrega

1. **Documento Técnico**
   - **Identificación del problema**:  
     Describir los problemas encontrados en el escenario propuesto de forma técnica, identificando correctamente las limitaciones y restricciones.

   - **Selección de metodologías**:  
     Explicar los patrones seleccionados, incluir diagramas UML y justificar técnicamente la propuesta.

   - **Diseño de una propuesta técnica**:  
     - Prototipo de la solución aplicando los patrones de diseño seleccionados.  
     - Código compartido en un repositorio Git personal.  
     - Enlace a un video de evidencia del proyecto corriendo localmente.


