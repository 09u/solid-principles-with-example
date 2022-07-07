import math
from .ShapeInterface import ShapeInterface
from .ManageShapeInterface import ManageShapeInterface

class Circle(ShapeInterface, ManageShapeInterface):
    def __init__(self, radius: int):
        self.radius = radius

    def area(self) -> float:
        return math.pi * (self.radius ** 2)

    def calculate(self) -> float:
        return self.area()

