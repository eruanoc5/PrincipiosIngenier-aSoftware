class GestorClientes:

    def __init__(self):
        self.lista_clientes = []
        self.log_interno = []

    def agregar_cliente(self, nombre):
        if nombre == "":
            return "Error: vacío"
        if nombre == "":
            return "Error: vacío"

        if self.validar_nombre_complejo(nombre):
            self.lista_clientes.append(nombre)
            self.log_interno.append("Cliente agregado")
            return "OK"
        else:
            return "No válido"

    def agregar_cliente_v2(self, nombre):
        if nombre == "":
            return "Error: vacío"

        self.lista_clientes.append(nombre)
        self.log_interno.append("Cliente agregado")
        return "OK"

    def mostrar_clientes(self):
        for c in self.lista_clientes:
            print("Cliente:", c)

    def mostrar_clientes_detallado(self):
        for c in self.lista_clientes:
            print("Cliente:", c)

    def validar_nombre_complejo(self, nombre):
        if nombre != "":
            if len(nombre) > 0:
                if nombre is not None:
                    if nombre != "admin":
                        return True
        return False

    def generar_reporte_futuro(self):
        print("Generando reporte avanzado...")

    def sincronizar_nube(self):
        print("Sincronizando con la nube...")

    def proceso_innecesario(self, nombre):
        if nombre != "":
            if nombre is not None:
                if len(nombre) > 0:
                    print("Procesando cliente...")
