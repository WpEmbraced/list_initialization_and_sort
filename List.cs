@{
  List<ItemViewModel> IgLeaders = new List<ItemViewModel>(@item.ParentItem().Fields.InterestGroupLeaders);
  IGLeaders.Sort((a, b) => a.Fields.LastName.CompareTo(b.Fields.LastName));
}

<ul>
  @foreach (var IgLeader in IgLeaders)
  {
    <li>@IgLeader.Fields.Title</li>
  }
</ul>
