Public Class Recipe
    Public mBakingPowder As Double
    Public mButter As Double
    Public mEgg As Integer
    Public mFlour As Double
    Public mMilk As Double
    Public mSalt As Double
    Public mSugar As Double
    Public mVegetableOil As Double

    'When If Statements UPGRADED then use mPossibleRecipe
    'Dim mPossibleRecipe As Boolean

    Public Property bakingPowder() As Double
        Get
            Return mBakingPowder
        End Get
        Set(ByVal value As Double)
            mBakingPowder = value
        End Set
    End Property

    Public Property butter() As Double
        Get
            Return mButter
        End Get
        Set(ByVal value As Double)
            mButter = value
        End Set
    End Property

    Public Property egg() As Integer
        Get
            Return mEgg
        End Get
        Set(ByVal value As Integer)
            mEgg = value
        End Set
    End Property

    Public Property flour() As Double
        Get
            Return mFlour
        End Get
        Set(ByVal value As Double)
            mFlour = value
        End Set
    End Property

    Public Property milk() As Double
        Get
            Return mMilk
        End Get
        Set(ByVal value As Double)
            mMilk = value
        End Set
    End Property

    Public Property salt() As Double
        Get
            Return mSalt
        End Get
        Set(ByVal value As Double)
            mSalt = value
        End Set
    End Property

    Public Property sugar() As Double
        Get
            Return mSugar
        End Get
        Set(ByVal value As Double)
            mSugar = value
        End Set
    End Property

    Public Property vegetableOil() As Double
        Get
            Return mVegetableOil
        End Get
        Set(ByVal value As Double)
            mVegetableOil = value
        End Set
    End Property

    'Public Property possibleRecipe() As Boolean
    'Get
    'Return mPossibleRecipe
    'End Get
    'Set(ByVal value As Boolean)
    'mPossibleRecipe = value
    'End Set
    'End Property

End Class
