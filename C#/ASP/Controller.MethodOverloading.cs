// Same method names will generate error in View

public ActionResult Test123()
{
    return View();
}

[ActionName(name: "AnotherName")]
public ActionResult Test123(int i)
{
    return View();
}

// Methods use HttpGet by default

[HttpPost]
public ActionResult Test123(string name)
{
    return View();
}