export class ScholarshipApplication {
  constructor(
    public AadharNumber: string = '', //check
    public Community: string = '', // check
    public FatherName: string = '', // check
    public MotherName: string = '', // check
    public Religion: string = '', // check
    public AnnualIncome: number | null = null, // check
    public InstituteName: string = '', // check - fetch from database
    public PresentCourse: string = '', //check
    public PresentCourseYear: number | null = null, // check
    public ModeOfStudy: string = '', //check
    public ClassStartDate: string = '', //check - again
    public UniversityBoardName: string = '', //check
    public PreviousCourse: string = '', //check
    public PreviousPassingYear: number | null = null, // check
    public PreviousClassPercentage: number | null = null, // check
    public RollNo10: string = '', //check
    public BoardName10: string = '', //check
    public PassingYear10: number | null = null, // check
    public Percentage10: number | null = null, // check
    public RollNo12: string = '', //check
    public BoardName12: string = '', //check
    public PassingYear12: number | null = null, // check
    public Percentage12: number | null = null, // check
    public AddmissionFee: number | null = null, // check
    public TutionFee: number | null = null, // check
    public OtherFee: number | null = null, // check
    public IsDisabled: string = '', //check
    public TypeOfDisability: string = '', //check
    public PercentageDisability: number | null = null, // check
    public MartialStatus: string = '', //check
    public ParentProfession: string = '', //check
    public State: string = '', //check
    public District: string = '', //check
    public Block: string = '', //check
    public HouseNumber: string = '', //check
    public StreetNumber: string = '', //check
    public Pincode: number | null = null, // check
    public SchemeId: number = 0, //check-get from server
    public InstituteCode: string = '',
    public DomicileCertificate: string = '', //
    public Photo: string = '',
    public InstituteIdCard: string = '',
    public CasteOrIncomeCertificate: string = '',
    public PreviousYearMarksheet: string = '',
    public FeeReceiptOfCurrentYear: string = '',
    public BankPassBook: string = '',
    public AadharCard: string = '',
    public MarkSheet10: string = '',
    public MarkSheet12: string = ''
  ) {}
}
