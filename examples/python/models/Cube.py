import math
from .ShapeInterface import ShapeInterface
from .ThreeDimensionalShapeInterface import ThreeDimensionalShapeInterface
from .ManageShapeInterface import ManageShapeInterface

class Cube(ShapeInterface, ThreeDimensionalShapeInterface, ManageShapeInterface):
    def __init__(self, length: int):
        self.length = length

    def area(self)->float:
        return 6 * (self.length**2)

    def volume(self)->float:
        return self.length**3

    def calculate(self) -> float:
        return self.area()


