import abc

class ShapeInterface(metaclass=abc.ABCMeta):
    def area(self)->float:
        raise NotImplementedError
