from .ShapeInterface import ShapeInterface
from .ManageShapeInterface import ManageShapeInterface

class Square(ShapeInterface, ManageShapeInterface):
    def __init__(self, length: int):
        self.length = length

    def area(self) -> float:
        return self.length ** 2

    def calculate(self) -> float:
        return self.area()
