import { KingTemplatePage } from './app.po';

describe('abp-project-name-template App', function() {
  let page: KingTemplatePage;

  beforeEach(() => {
    page = new KingTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
