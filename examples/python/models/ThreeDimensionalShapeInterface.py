import abc

class ThreeDimensionalShapeInterface(metaclass=abc.ABCMeta):
    def volume(self)->float:
        raise NotImplementedError
