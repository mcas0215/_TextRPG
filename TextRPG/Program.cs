/* 스파르타 던전에 오신 여러분 환영합니다.
 * 원하시는 이름을 설정해주세요
 * 이름 설정하면 '이름'..'이름'님.....
 * '이름'님! 정신 좀 차려보세요!
 * 다른 사람들은 벌써 출발했다고요! 저희도 어서 가야된다고요!
 * ~~~뭐시라 스토리 일단 넘어가고
 * 일단 뭐부터 할까?
 * -----------------------------------------------
 * 1. 상태 보기
 * 2. 인벤토리
 * 3. 상점
 * 0. 나가기
 * 원하시는 행동을 입력해주세요.
 * ------------------------------------------------
 * 1.상태 보기
 * 캐릭터의 정보를 볼 수 있습니다.
 * 
 * Lv. ??
 * 직업: (??)
 * 공격력 : ??
 * 방어력 : ??
 * 체력 : ??
 * Gold: ??G
 * 
 * 0. 나가기
 * 원하시는 행동을 입력해주세요.
 * -------------------------------------------------
 * 2. 인벤토리
 * 보유 중인 아이템을 관리할 수 있습니다.
 * 
 * [아이템 목록]
 * [E]??
 * ??
 * ??
 * 
 * 1. 장착 관리
 * 0. 나가기
 * 원하시는 행동을 입력해주세요.
 * 
 * --------------------------------------------------
 * 1.장착 관리
 * 
 * [아이템 목록]
 * 1. [E]??
 * 2. ??
 * 3. ??
 * 
 * 아이템을 선택해주세요. (없는 숫자를 고르면 잘못된 입력입니다. 출력)
 * ---------------------------------------------------
 * ?? 아이템을 장착하시겠습니까?
 * 
 * 1. 장착 (만약 이미 착용 중인거면 장착 헤제 하시겠습니까? 로 바뀜)
 * 0. 나가기
 * -----------------------------------------------------
 * 
 * 3. 상점
 * 필요한 아이템을 얻을 수 있는 상점입니다.
 * 
 * [보유 골드]
 * ??G
 * 
 * [아이템 목록]
 * -??
 * 
 * -??
 * 
 * -??
 * 
 * 1. 아이템 구매
 * 0. 나가기
 * -----------------------------------------------------------
 * 1. 아이템 구매
 * 
 * [보유 골드]
 * ??G
 * 
 * [아이템 목록]
 * 1. ??
 * 
 * 2. ??
 * 
 * 3. ??
 * 
 * 아이템을 선택해주세요.
 * -----------------------------------------------------------
 * ?? 아이템을 구매하시겠습니까?
 * 
 * 1. 구매(이미 구매, 구매 완료, 골드 부족으로 나뉨)
 * 0. 나가기
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        StartGame();
    }

    static void StartGame()
    {
        Console.WriteLine("스파르타 던전에 오신 여러분 환영합니다.");
        Console.Write("원하시는 이름을 설정해주세요: ");
        string playerName = Console.ReadLine();

        Console.Clear();
        Console.WriteLine($"{playerName}.. {playerName}님.....");
        Console.WriteLine($"{playerName}님! 정신 좀 차려보세요!");
        Console.Write("다른 사람들은 벌써 출발했어요! 저희도 어서 가야된다고요!");
        Thread.Sleep(5000);
        Console.Clear();
        Console.WriteLine("일단 뭐부터 할까?");

        ShowMainMenu(playerName);
    }

    static void ShowMainMenu(string playerName)
    {
        while (true)
        {
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("1. 상태 보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점");
            Console.WriteLine("0. 나가기");
            Console.Write("원하시는 행동을 입력해주세요: ");

            string input = Console.ReadLine();
            Console.Clear();

            switch (input)
            {
                case "1":
                    ShowStatus(playerName);
                    break;
                case "2":
                    ShowInventory();
                    break;
                case "3":
                    ShowShop();
                    break;
                case "0":
                    Console.WriteLine("게임을 종료합니다.");
                    return;
                default:
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    break;
            }
        }
    }

    static void ShowStatus(string playerName)
    {
        Console.WriteLine("캐릭터의 정보를 볼 수 있습니다.");
        Console.WriteLine($"\nLv. 1");
        Console.WriteLine("직업: 궁수");
        Console.WriteLine("공격력 : 10");
        Console.WriteLine("방어력 : 5");
        Console.WriteLine("체력 : 100");
        Console.WriteLine("Gold: 100G\n");

        Console.WriteLine("0. 나가기");
        Console.Write("원하시는 행동을 입력해주세요: ");
        string input = Console.ReadLine();
        Console.Clear();

    }

    static void ShowInventory()
    {
        Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");
        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("[E] 낡은 검\n");
        Console.WriteLine("가죽 갑옷\n");
        Console.WriteLine("돌 갑옷\n");
        Console.WriteLine("철 검\n");
        Console.WriteLine("흰 양말\n");

        Console.WriteLine("1. 장착 관리");
        Console.WriteLine("0. 나가기");
        Console.Write("원하시는 행동을 입력해주세요: ");
        string input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {
            case "1":
                InventoryChange();
                break;
            case "0":
                Console.Clear();
                break;
            default:
                Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                break;
        }

    }

    static void InventoryChange()
    {
        Console.WriteLine("잠깐..나 엄청 세잖아..? 다른 아이템 따윈 필요없어!");
        Thread.Sleep(3000);
        Console.Clear() ;
    }
    
    



    static void ShowShop()
    {
        Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.\n");
        Console.WriteLine("[보유 골드]");
        Console.WriteLine("100G\n");

        Console.WriteLine("[아이템 목록]");
        Console.WriteLine("- 다이아 검\n");
        Console.WriteLine("- 강철 방패\n");
        Console.WriteLine("- 포션\n");

        Console.WriteLine("1. 아이템 구매");
        Console.WriteLine("0. 나가기");
        Console.Write("원하시는 행동을 입력해주세요: ");
        string input = Console.ReadLine();
        Console.Clear();

        switch (input)
        {  case "1":
            ItemShopping()
            ; break;
            case "0":
            Console.Clear(); 
              break;
            default:
             Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
              break;




        }
    static void ItemShopping()
        {
            Console.WriteLine("흠..둘러보니 여기 물건은 품질이 좋지 않다...다음에 다시 오자.");
            Thread.Sleep(3000);
            Console.Clear();

        }




    }
}
