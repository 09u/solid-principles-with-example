# import sys
# import os

# sys.path.append(os.path.abspath(os.path.join(
#     os.path.dirname(__file__), '..')
# ))

import abc
import math
import json


class ShapeInterface(metaclass=abc.ABCMeta):
    def area(self)->float:
        raise NotImplementedError


class ThreeDimensionalShapeInterface(metaclass=abc.ABCMeta):
    def volume(self)->float:
        raise NotImplementedError


class ManageShapeInterface(metaclass=abc.ABCMeta):
    def calculate(self)->float:
        raise NotImplementedError


class Square(ShapeInterface, ManageShapeInterface):
    def __init__(self, length: int):
        self.length = length
    
    def area(self) -> float:
        return self.length ** 2

    def calculate(self) -> float:
        return self.area()


class Circle(ShapeInterface, ManageShapeInterface):
    def __init__(self, radius: int):
        self.radius = radius

    def area(self) -> float:
        return math.pi * (self.radius ** 2)

    def calculate(self) -> float:
        return self.area()


class Cube(ShapeInterface, ThreeDimensionalShapeInterface, ManageShapeInterface):
    def __init__(self, length: int):
        self.length = length

    def area(self)->float:
        return 6 * (self.length**2)

    def volume(self)->float:
        return self.length**3

    def calculate(self) -> float:
        return self.area()


class AreaCalculator:
    def __init__(self, shapes: list):
        self.shapes = shapes

    def sum(self):

        sum_area = 0

        for shape in self.shapes:
            if(issubclass(type(shape), ManageShapeInterface)):
                sum_area += shape.calculate()
            else:
                raise SystemError
        return sum_area


class VolumeCalculator(AreaCalculator):
    def __init__(self, shapes: list):
        super().__init__(shapes)
    
    def sum(self) -> float:
        vol_sum = 0
        for shape in self.shapes:
            if(issubclass(type(shape), ThreeDimensionalShapeInterface)):
                vol_sum += shape.volume()

        return vol_sum


class SumCalculatorOutputter:
    def __init__(self, calculator: AreaCalculator):
        self.calculator = calculator
    
    def JSON(self):
        return json.dumps({'sum': self.calculator.sum()}, sort_keys=True)        

    def Message(self) -> str:
        return f"Sum of the areas of provided shapes: {self.calculator.sum():.2f}"
        

'''
Here is an example with a collection of three shapes:

a circle with a radius of 2
a square with a length of 5
a second square with a length of 6
'''

shapes = [
  Circle(2),
  Square(5),
  Cube(2),
  Cube(5)
]

areas = AreaCalculator(shapes)
output0 = SumCalculatorOutputter(areas)

volumes = VolumeCalculator(shapes)
output1 = SumCalculatorOutputter(volumes)

print(output0.JSON())
print(output0.Message())
print(output1.JSON())
print(output1.Message())