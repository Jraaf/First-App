export class TextConstatns{
    private readonly _cardTitle:string = "Card name";
    private readonly _cardDescription:string = "Description should be nice and precise";

    private readonly _CardUrl="https://localhost:7082/api/Cards";
    constructor(){ }
    public cardTitle():string{
        return this._cardTitle;
    }
    public cardDescriprion():string{
        return this._cardDescription;
    }
    public CardUrl():string{
        return this._CardUrl;
    }
}
