class GestorProductos:

    def __init__(self):
        self.lista_productos = []
        self.historial = []

    def agregar_producto(self, nombre):
        if nombre == "":
            return "Error"
        if nombre == "":
            return "Error"

        if self.validacion_avanzada(nombre):
            self.lista_productos.append(nombre)
            self.historial.append("Producto agregado")
            return "OK"
        else:
            return "No válido"

    def agregar_producto_v2(self, nombre):
        if nombre == "":
            return "Error"

        self.lista_productos.append(nombre)
        self.historial.append("Producto agregado")
        return "OK"

    def mostrar_productos(self):
        for p in self.lista_productos:
            print("Producto:", p)

    def mostrar_productos_detallado(self):
        for p in self.lista_productos:
            print("Producto:", p)

    def validacion_avanzada(self, nombre):
        if nombre != "":
            if len(nombre) > 0:
                if nombre is not None:
                    if nombre != "test":
                        return True
        return False

    def generar_estadisticas(self):
        print("Generando estadísticas...")

    def sincronizar_api_externa(self):
        print("Sincronizando con API externa...")

    def proceso_extra(self, nombre):
        if nombre != "":
            if nombre is not None:
                if len(nombre) > 0:
                    print("Procesando producto...")
